namespace Compuscan
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtInputFile = new System.Windows.Forms.ListBox();
            this.txtOutPutFile = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(3, 29);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(287, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // txtInputFile
            // 
            this.txtInputFile.FormattingEnabled = true;
            this.txtInputFile.Location = new System.Drawing.Point(35, 98);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(290, 316);
            this.txtInputFile.TabIndex = 2;
            // 
            // txtOutPutFile
            // 
            this.txtOutPutFile.FormattingEnabled = true;
            this.txtOutPutFile.Location = new System.Drawing.Point(348, 98);
            this.txtOutPutFile.Name = "txtOutPutFile";
            this.txtOutPutFile.Size = new System.Drawing.Size(291, 316);
            this.txtOutPutFile.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(35, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 79);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save to File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(290, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 479);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOutPutFile);
            this.Controls.Add(this.txtInputFile);
            this.Name = "Form1";
            this.Text = "Compuscan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ListBox txtInputFile;
        private System.Windows.Forms.ListBox txtOutPutFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

