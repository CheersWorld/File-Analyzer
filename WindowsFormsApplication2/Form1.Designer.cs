namespace WindowsFormsApplication2
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
            this.ofd_button = new System.Windows.Forms.Button();
            this.loaded_file_display = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.file_length = new System.Windows.Forms.TextBox();
            this.spaces_display = new System.Windows.Forms.TextBox();
            this.show_frequenzy = new System.Windows.Forms.Button();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ofd_button
            // 
            this.ofd_button.Location = new System.Drawing.Point(12, 12);
            this.ofd_button.Name = "ofd_button";
            this.ofd_button.Size = new System.Drawing.Size(83, 23);
            this.ofd_button.TabIndex = 0;
            this.ofd_button.Text = "Open file";
            this.ofd_button.UseVisualStyleBackColor = true;
            this.ofd_button.Click += new System.EventHandler(this.ofd_button_Click);
            // 
            // loaded_file_display
            // 
            this.loaded_file_display.Location = new System.Drawing.Point(101, 14);
            this.loaded_file_display.Name = "loaded_file_display";
            this.loaded_file_display.ReadOnly = true;
            this.loaded_file_display.Size = new System.Drawing.Size(191, 20);
            this.loaded_file_display.TabIndex = 1;
            this.loaded_file_display.Text = "Loaded file: none";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 42);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(280, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Analyze";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // file_length
            // 
            this.file_length.Location = new System.Drawing.Point(13, 72);
            this.file_length.Name = "file_length";
            this.file_length.ReadOnly = true;
            this.file_length.Size = new System.Drawing.Size(159, 20);
            this.file_length.TabIndex = 3;
            this.file_length.Text = "Total signs in file: ";
            // 
            // spaces_display
            // 
            this.spaces_display.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.spaces_display.Location = new System.Drawing.Point(178, 71);
            this.spaces_display.Name = "spaces_display";
            this.spaces_display.ReadOnly = true;
            this.spaces_display.Size = new System.Drawing.Size(114, 20);
            this.spaces_display.TabIndex = 4;
            this.spaces_display.Text = "Spaces: ";
            // 
            // show_frequenzy
            // 
            this.show_frequenzy.Enabled = false;
            this.show_frequenzy.Location = new System.Drawing.Point(13, 98);
            this.show_frequenzy.Name = "show_frequenzy";
            this.show_frequenzy.Size = new System.Drawing.Size(279, 23);
            this.show_frequenzy.TabIndex = 5;
            this.show_frequenzy.Text = "Show letter frequency";
            this.show_frequenzy.UseVisualStyleBackColor = true;
            this.show_frequenzy.Click += new System.EventHandler(this.show_frequenzy_Click);
            // 
            // pBar1
            // 
            this.pBar1.Enabled = false;
            this.pBar1.Location = new System.Drawing.Point(13, 128);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(279, 15);
            this.pBar1.Step = 1;
            this.pBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 148);
            this.Controls.Add(this.pBar1);
            this.Controls.Add(this.show_frequenzy);
            this.Controls.Add(this.spaces_display);
            this.Controls.Add(this.file_length);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.loaded_file_display);
            this.Controls.Add(this.ofd_button);
            this.Name = "Form1";
            this.Text = "Text Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ofd_button;
        private System.Windows.Forms.TextBox loaded_file_display;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox file_length;
        private System.Windows.Forms.TextBox spaces_display;
        private System.Windows.Forms.Button show_frequenzy;
        private System.Windows.Forms.ProgressBar pBar1;

    }
}

