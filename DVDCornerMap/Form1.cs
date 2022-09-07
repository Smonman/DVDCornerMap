using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVD_Corner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetControlsState(Control.ControlCollection cc, bool state, Type[] types)
        {
            foreach (Control c in cc)
            {
                foreach (Type t in types)
                {
                    if (c.GetType() == t && c.Name != "button_cancel")
                    {
                        c.Invoke((MethodInvoker)(() => c.Enabled = state));
                    }

                    if (c.GetType() == typeof(GroupBox) && !types.Contains(typeof(GroupBox)))
                    {
                        SetControlsState(c.Controls, state, types);
                    }
                }
            }
        }

        private void SetProgressbar(ProgressBar pb, Label descL, Label percL, int max, string desc)
        {
            pb.Invoke((MethodInvoker)(() => pb.Maximum = max));
            pb.Invoke((MethodInvoker)(() => pb.Value = 0));
            descL.Invoke((MethodInvoker)(() => descL.Text = desc));
            percL.Invoke((MethodInvoker)(() => percL.Text = string.Format("{0:P4}", 0)));
        }

        private void ProgressbarStep(ProgressBar pb, Label percL, int value)
        {
            double p = (double)value / pb.Maximum;
            pb.Invoke((MethodInvoker)(() => pb.Value = (int)(p * pb.Maximum)));
            percL.Invoke((MethodInvoker)(() => percL.Text = string.Format("{0:P2}", p)));
        }

        private void button_simulate_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.WorkerSupportsCancellation)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void StartSimulatingProcess(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;

            Logo l = new Logo((int)numericUpDown_l_w.Value, (int)numericUpDown_l_h.Value);
            Display d = new Display((int)numericUpDown_d_w.Value, (int)numericUpDown_d_h.Value, l);

            int[,] corners = new int[d.Width - l.Width, d.Height - l.Height];

            int xs = (int)numericUpDown_l_xspeed.Value;
            int ys = (int)numericUpDown_l_yspeed.Value;

            int maxC = (int)numericUpDown_col.Value;

            SetProgressbar(progressBar, label_progressbar_desc, label_progressbar_percentage, d.Width - l.Width, "Simulation");

            for (int x = 0; x < corners.GetLength(0); x++)
            {
                for (int y = 0; y < corners.GetLength(1); y++)
                {
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    d.Logo.SetSpeed(xs, ys);
                    d.Logo.SetPos(x, y); 
                    corners[x, y] = d.Simulate(maxC);
                }

                if (e.Cancel)
                {
                    break;
                }

                //Console.WriteLine("Simulation: " + (double)x / (d.Width - l.Width) * 100d + "%");
                ProgressbarStep(progressBar, label_progressbar_percentage, x);
            }

            if (!e.Cancel)
            {
                GenerateBitmap(d, l, corners, sender, e);
            }

        }

        private void GenerateBitmap(Display d, Logo l, int[,] brightness, object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;

            Bitmap b = new Bitmap(d.Width, d.Height);

            SetProgressbar(progressBar, label_progressbar_desc, label_progressbar_percentage, b.Width, "Blackening");

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    if (bw.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                    b.SetPixel(x, y, Color.Black);
                }

                if (e.Cancel)
                {
                    break;
                }

                //Console.WriteLine("Blackening: " + (double)x / b.Width * 100d + "%");
                ProgressbarStep(progressBar, label_progressbar_percentage, x);
            }

            if (!e.Cancel)
            {
                SetProgressbar(progressBar, label_progressbar_desc, label_progressbar_percentage, brightness.GetLength(0), "Painting");

                for (int x = 0; x < brightness.GetLength(0); x++)
                {
                    for (int y = 0; y < brightness.GetLength(1); y++)
                    {
                        if (bw.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }

                        int br = (int)Math.Floor((double)brightness[x, y] / d.MaxCorners * 255);
                        b.SetPixel(x + (int)Math.Floor(l.Width / 2d), y + (int)Math.Floor(l.Height / 2d), Color.FromArgb(br, br, br));
                    }

                    if (e.Cancel)
                    {
                        break;
                    }

                    //Console.WriteLine("Bitmap: " + (double)x / brightness.GetLength(0) * 100d + "%");
                    ProgressbarStep(progressBar, label_progressbar_percentage, x);
                }

                if (!e.Cancel)
                {
                    pictureBox_output.Image = b;
                }

            }
            //b.Dispose();

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SetControlsState(groupBox_input.Controls, false, new Type[] { typeof(Label), typeof(Button), typeof(NumericUpDown) });
            StartSimulatingProcess(sender, e);
            SetControlsState(groupBox_input.Controls, true, new Type[] { typeof(Label), typeof(Button), typeof(NumericUpDown) });
        }
    }
}
