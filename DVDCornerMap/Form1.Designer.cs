namespace DVD_Corner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_input = new System.Windows.Forms.GroupBox();
            this.numericUpDown_col = new System.Windows.Forms.NumericUpDown();
            this.label_col = new System.Windows.Forms.Label();
            this.groupBox_actions = new System.Windows.Forms.GroupBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_simulate = new System.Windows.Forms.Button();
            this.groupBox_logo = new System.Windows.Forms.GroupBox();
            this.numericUpDown_l_yspeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_l_xspeed = new System.Windows.Forms.NumericUpDown();
            this.label_l_yspeed = new System.Windows.Forms.Label();
            this.label_l_xspeed = new System.Windows.Forms.Label();
            this.numericUpDown_l_h = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_l_w = new System.Windows.Forms.NumericUpDown();
            this.label_l_h = new System.Windows.Forms.Label();
            this.label_l_w = new System.Windows.Forms.Label();
            this.groupBox_display = new System.Windows.Forms.GroupBox();
            this.numericUpDown_d_h = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_d_w = new System.Windows.Forms.NumericUpDown();
            this.label_d_h = new System.Windows.Forms.Label();
            this.label_d_w = new System.Windows.Forms.Label();
            this.pictureBox_output = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_progressbar_percentage = new System.Windows.Forms.Label();
            this.label_progressbar_desc = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox_input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_col)).BeginInit();
            this.groupBox_actions.SuspendLayout();
            this.groupBox_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_yspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_xspeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_w)).BeginInit();
            this.groupBox_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_d_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_d_w)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_input
            // 
            this.groupBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_input.Controls.Add(this.numericUpDown_col);
            this.groupBox_input.Controls.Add(this.label_col);
            this.groupBox_input.Controls.Add(this.groupBox_actions);
            this.groupBox_input.Controls.Add(this.groupBox_logo);
            this.groupBox_input.Controls.Add(this.groupBox_display);
            this.groupBox_input.Location = new System.Drawing.Point(12, 12);
            this.groupBox_input.Name = "groupBox_input";
            this.groupBox_input.Size = new System.Drawing.Size(237, 426);
            this.groupBox_input.TabIndex = 0;
            this.groupBox_input.TabStop = false;
            this.groupBox_input.Text = "Input";
            // 
            // numericUpDown_col
            // 
            this.numericUpDown_col.Location = new System.Drawing.Point(100, 243);
            this.numericUpDown_col.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_col.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_col.Name = "numericUpDown_col";
            this.numericUpDown_col.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_col.TabIndex = 4;
            this.numericUpDown_col.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_col
            // 
            this.label_col.AutoSize = true;
            this.label_col.Location = new System.Drawing.Point(14, 245);
            this.label_col.Name = "label_col";
            this.label_col.Size = new System.Drawing.Size(84, 13);
            this.label_col.TabIndex = 3;
            this.label_col.Text = "Collisions / Run:";
            // 
            // groupBox_actions
            // 
            this.groupBox_actions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_actions.Controls.Add(this.button_cancel);
            this.groupBox_actions.Controls.Add(this.button_simulate);
            this.groupBox_actions.Location = new System.Drawing.Point(6, 343);
            this.groupBox_actions.Name = "groupBox_actions";
            this.groupBox_actions.Size = new System.Drawing.Size(223, 77);
            this.groupBox_actions.TabIndex = 2;
            this.groupBox_actions.TabStop = false;
            this.groupBox_actions.Text = "Actions";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(6, 48);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_simulate
            // 
            this.button_simulate.Location = new System.Drawing.Point(6, 19);
            this.button_simulate.Name = "button_simulate";
            this.button_simulate.Size = new System.Drawing.Size(75, 23);
            this.button_simulate.TabIndex = 0;
            this.button_simulate.Text = "Simulate";
            this.button_simulate.UseVisualStyleBackColor = true;
            this.button_simulate.Click += new System.EventHandler(this.button_simulate_Click);
            // 
            // groupBox_logo
            // 
            this.groupBox_logo.Controls.Add(this.numericUpDown_l_yspeed);
            this.groupBox_logo.Controls.Add(this.numericUpDown_l_xspeed);
            this.groupBox_logo.Controls.Add(this.label_l_yspeed);
            this.groupBox_logo.Controls.Add(this.label_l_xspeed);
            this.groupBox_logo.Controls.Add(this.numericUpDown_l_h);
            this.groupBox_logo.Controls.Add(this.numericUpDown_l_w);
            this.groupBox_logo.Controls.Add(this.label_l_h);
            this.groupBox_logo.Controls.Add(this.label_l_w);
            this.groupBox_logo.Location = new System.Drawing.Point(6, 99);
            this.groupBox_logo.Name = "groupBox_logo";
            this.groupBox_logo.Size = new System.Drawing.Size(223, 133);
            this.groupBox_logo.TabIndex = 1;
            this.groupBox_logo.TabStop = false;
            this.groupBox_logo.Text = "Logo";
            // 
            // numericUpDown_l_yspeed
            // 
            this.numericUpDown_l_yspeed.Location = new System.Drawing.Point(94, 105);
            this.numericUpDown_l_yspeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_l_yspeed.Name = "numericUpDown_l_yspeed";
            this.numericUpDown_l_yspeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_l_yspeed.TabIndex = 11;
            this.numericUpDown_l_yspeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_l_xspeed
            // 
            this.numericUpDown_l_xspeed.Location = new System.Drawing.Point(94, 79);
            this.numericUpDown_l_xspeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_l_xspeed.Name = "numericUpDown_l_xspeed";
            this.numericUpDown_l_xspeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_l_xspeed.TabIndex = 10;
            this.numericUpDown_l_xspeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_l_yspeed
            // 
            this.label_l_yspeed.AutoSize = true;
            this.label_l_yspeed.Location = new System.Drawing.Point(8, 107);
            this.label_l_yspeed.Name = "label_l_yspeed";
            this.label_l_yspeed.Size = new System.Drawing.Size(51, 13);
            this.label_l_yspeed.TabIndex = 9;
            this.label_l_yspeed.Text = "Y-Speed:";
            // 
            // label_l_xspeed
            // 
            this.label_l_xspeed.AutoSize = true;
            this.label_l_xspeed.Location = new System.Drawing.Point(8, 81);
            this.label_l_xspeed.Name = "label_l_xspeed";
            this.label_l_xspeed.Size = new System.Drawing.Size(51, 13);
            this.label_l_xspeed.TabIndex = 8;
            this.label_l_xspeed.Text = "X-Speed:";
            // 
            // numericUpDown_l_h
            // 
            this.numericUpDown_l_h.Location = new System.Drawing.Point(94, 53);
            this.numericUpDown_l_h.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_l_h.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_l_h.Name = "numericUpDown_l_h";
            this.numericUpDown_l_h.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_l_h.TabIndex = 7;
            this.numericUpDown_l_h.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_l_w
            // 
            this.numericUpDown_l_w.Location = new System.Drawing.Point(94, 27);
            this.numericUpDown_l_w.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_l_w.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_l_w.Name = "numericUpDown_l_w";
            this.numericUpDown_l_w.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_l_w.TabIndex = 6;
            this.numericUpDown_l_w.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label_l_h
            // 
            this.label_l_h.AutoSize = true;
            this.label_l_h.Location = new System.Drawing.Point(8, 55);
            this.label_l_h.Name = "label_l_h";
            this.label_l_h.Size = new System.Drawing.Size(41, 13);
            this.label_l_h.TabIndex = 5;
            this.label_l_h.Text = "Height:";
            // 
            // label_l_w
            // 
            this.label_l_w.AutoSize = true;
            this.label_l_w.Location = new System.Drawing.Point(8, 29);
            this.label_l_w.Name = "label_l_w";
            this.label_l_w.Size = new System.Drawing.Size(38, 13);
            this.label_l_w.TabIndex = 4;
            this.label_l_w.Text = "Width:";
            // 
            // groupBox_display
            // 
            this.groupBox_display.Controls.Add(this.numericUpDown_d_h);
            this.groupBox_display.Controls.Add(this.numericUpDown_d_w);
            this.groupBox_display.Controls.Add(this.label_d_h);
            this.groupBox_display.Controls.Add(this.label_d_w);
            this.groupBox_display.Location = new System.Drawing.Point(6, 19);
            this.groupBox_display.Name = "groupBox_display";
            this.groupBox_display.Size = new System.Drawing.Size(223, 74);
            this.groupBox_display.TabIndex = 0;
            this.groupBox_display.TabStop = false;
            this.groupBox_display.Text = "Display";
            // 
            // numericUpDown_d_h
            // 
            this.numericUpDown_d_h.Location = new System.Drawing.Point(95, 45);
            this.numericUpDown_d_h.Maximum = new decimal(new int[] {
            4800,
            0,
            0,
            0});
            this.numericUpDown_d_h.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_d_h.Name = "numericUpDown_d_h";
            this.numericUpDown_d_h.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_d_h.TabIndex = 3;
            this.numericUpDown_d_h.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // numericUpDown_d_w
            // 
            this.numericUpDown_d_w.Location = new System.Drawing.Point(95, 19);
            this.numericUpDown_d_w.Maximum = new decimal(new int[] {
            6400,
            0,
            0,
            0});
            this.numericUpDown_d_w.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown_d_w.Name = "numericUpDown_d_w";
            this.numericUpDown_d_w.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_d_w.TabIndex = 2;
            this.numericUpDown_d_w.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
            // 
            // label_d_h
            // 
            this.label_d_h.AutoSize = true;
            this.label_d_h.Location = new System.Drawing.Point(9, 47);
            this.label_d_h.Name = "label_d_h";
            this.label_d_h.Size = new System.Drawing.Size(41, 13);
            this.label_d_h.TabIndex = 1;
            this.label_d_h.Text = "Height:";
            // 
            // label_d_w
            // 
            this.label_d_w.AutoSize = true;
            this.label_d_w.Location = new System.Drawing.Point(9, 21);
            this.label_d_w.Name = "label_d_w";
            this.label_d_w.Size = new System.Drawing.Size(38, 13);
            this.label_d_w.TabIndex = 0;
            this.label_d_w.Text = "Width:";
            // 
            // pictureBox_output
            // 
            this.pictureBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_output.Location = new System.Drawing.Point(255, 12);
            this.pictureBox_output.Name = "pictureBox_output";
            this.pictureBox_output.Size = new System.Drawing.Size(533, 397);
            this.pictureBox_output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_output.TabIndex = 1;
            this.pictureBox_output.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(323, 415);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(397, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 2;
            // 
            // label_progressbar_percentage
            // 
            this.label_progressbar_percentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_progressbar_percentage.BackColor = System.Drawing.Color.Transparent;
            this.label_progressbar_percentage.Location = new System.Drawing.Point(726, 415);
            this.label_progressbar_percentage.Name = "label_progressbar_percentage";
            this.label_progressbar_percentage.Size = new System.Drawing.Size(62, 23);
            this.label_progressbar_percentage.TabIndex = 3;
            this.label_progressbar_percentage.Text = "0.00000%";
            this.label_progressbar_percentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_progressbar_desc
            // 
            this.label_progressbar_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_progressbar_desc.BackColor = System.Drawing.Color.Transparent;
            this.label_progressbar_desc.Location = new System.Drawing.Point(255, 415);
            this.label_progressbar_desc.Name = "label_progressbar_desc";
            this.label_progressbar_desc.Size = new System.Drawing.Size(62, 23);
            this.label_progressbar_desc.TabIndex = 4;
            this.label_progressbar_desc.Text = "Simulation";
            this.label_progressbar_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_progressbar_desc);
            this.Controls.Add(this.label_progressbar_percentage);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox_output);
            this.Controls.Add(this.groupBox_input);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DVD Corner Map";
            this.groupBox_input.ResumeLayout(false);
            this.groupBox_input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_col)).EndInit();
            this.groupBox_actions.ResumeLayout(false);
            this.groupBox_logo.ResumeLayout(false);
            this.groupBox_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_yspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_xspeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_l_w)).EndInit();
            this.groupBox_display.ResumeLayout(false);
            this.groupBox_display.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_d_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_d_w)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_input;
        private System.Windows.Forms.GroupBox groupBox_logo;
        private System.Windows.Forms.GroupBox groupBox_display;
        private System.Windows.Forms.Label label_d_w;
        private System.Windows.Forms.Label label_d_h;
        private System.Windows.Forms.NumericUpDown numericUpDown_d_h;
        private System.Windows.Forms.NumericUpDown numericUpDown_d_w;
        private System.Windows.Forms.NumericUpDown numericUpDown_l_h;
        private System.Windows.Forms.NumericUpDown numericUpDown_l_w;
        private System.Windows.Forms.Label label_l_h;
        private System.Windows.Forms.Label label_l_w;
        private System.Windows.Forms.GroupBox groupBox_actions;
        private System.Windows.Forms.Button button_simulate;
        private System.Windows.Forms.PictureBox pictureBox_output;
        private System.Windows.Forms.NumericUpDown numericUpDown_l_yspeed;
        private System.Windows.Forms.NumericUpDown numericUpDown_l_xspeed;
        private System.Windows.Forms.Label label_l_yspeed;
        private System.Windows.Forms.Label label_l_xspeed;
        private System.Windows.Forms.Label label_col;
        private System.Windows.Forms.NumericUpDown numericUpDown_col;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_progressbar_percentage;
        private System.Windows.Forms.Label label_progressbar_desc;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Button button_cancel;
    }
}

