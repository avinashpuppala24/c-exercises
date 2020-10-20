namespace picture_view_app
{
    partial class picture_Form1
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

          Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stretch_checkBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.show_button = new System.Windows.Forms.Button();
            this.picture_button = new System.Windows.Forms.Button();
            this.background_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stretch_checkBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1386, 598);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1380, 532);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stretch_checkBox
            // 
            this.stretch_checkBox.AutoSize = true;
            this.stretch_checkBox.Location = new System.Drawing.Point(3, 541);
            this.stretch_checkBox.Name = "stretch_checkBox";
            this.stretch_checkBox.Size = new System.Drawing.Size(73, 21);
            this.stretch_checkBox.TabIndex = 1;
            this.stretch_checkBox.Text = "stretch";
            this.stretch_checkBox.UseVisualStyleBackColor = true;
            this.stretch_checkBox.CheckedChanged += new System.EventHandler(this.stretch_checkBox_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.show_button);
            this.flowLayoutPanel1.Controls.Add(this.picture_button);
            this.flowLayoutPanel1.Controls.Add(this.background_button);
            this.flowLayoutPanel1.Controls.Add(this.close_button);
            this.flowLayoutPanel1.Controls.Add(this.next_button);
            this.flowLayoutPanel1.Controls.Add(this.previous_button);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(210, 541);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1173, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // show_button
            // 
            this.show_button.AutoSize = true;
            this.show_button.Location = new System.Drawing.Point(1024, 3);
            this.show_button.Name = "show_button";
            this.show_button.Size = new System.Drawing.Size(146, 42);
            this.show_button.TabIndex = 0;
            this.show_button.Text = "show the picture";
            this.show_button.UseVisualStyleBackColor = true;
            this.show_button.Click += new System.EventHandler(this.show_button_Click);
            // 
            // picture_button
            // 
            this.picture_button.AutoSize = true;
            this.picture_button.Location = new System.Drawing.Point(880, 3);
            this.picture_button.Name = "picture_button";
            this.picture_button.Size = new System.Drawing.Size(138, 42);
            this.picture_button.TabIndex = 1;
            this.picture_button.Text = "clear the picture";
            this.picture_button.UseVisualStyleBackColor = true;
            this.picture_button.Click += new System.EventHandler(this.picture_button_Click);
            // 
            // background_button
            // 
            this.background_button.AutoSize = true;
            this.background_button.Location = new System.Drawing.Point(649, 3);
            this.background_button.Name = "background_button";
            this.background_button.Size = new System.Drawing.Size(225, 42);
            this.background_button.TabIndex = 2;
            this.background_button.Text = "set the background colour";
            this.background_button.UseVisualStyleBackColor = true;
            this.background_button.Click += new System.EventHandler(this.background_button_Click);
            // 
            // close_button
            // 
            this.close_button.AutoSize = true;
            this.close_button.Location = new System.Drawing.Point(514, 3);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(129, 42);
            this.close_button.TabIndex = 3;
            this.close_button.Text = "close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // next_button
            // 
            this.next_button.Enabled = false;
            this.next_button.Location = new System.Drawing.Point(418, 3);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(90, 42);
            this.next_button.TabIndex = 4;
            this.next_button.Text = "next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.Enabled = false;
            this.previous_button.Location = new System.Drawing.Point(322, 3);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(90, 42);
            this.previous_button.TabIndex = 5;
            this.previous_button.Text = "previous";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "select the picture file";
            // 
            // picture_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "picture_Form1";
            this.Text = "my picture viewer";
            this.Load += new System.EventHandler(this.picture_Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox stretch_checkBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button show_button;
        private System.Windows.Forms.Button picture_button;
        private System.Windows.Forms.Button background_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button previous_button;
    }
}

