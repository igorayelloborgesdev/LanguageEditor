namespace LanguageEditor
{
    partial class LanguageForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mark = new System.Windows.Forms.GroupBox();
            this.Load = new System.Windows.Forms.Button();
            this.savefile = new System.Windows.Forms.Button();
            this.PortugueseKey = new System.Windows.Forms.TextBox();
            this.EnglishKey = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileLoaded = new System.Windows.Forms.Label();
            this.mark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "English";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Portuguese";
            // 
            // mark
            // 
            this.mark.Controls.Add(this.fileLoaded);
            this.mark.Controls.Add(this.Load);
            this.mark.Controls.Add(this.savefile);
            this.mark.Controls.Add(this.PortugueseKey);
            this.mark.Controls.Add(this.EnglishKey);
            this.mark.Controls.Add(this.label3);
            this.mark.Controls.Add(this.label4);
            this.mark.Location = new System.Drawing.Point(12, 12);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(350, 151);
            this.mark.TabIndex = 7;
            this.mark.TabStop = false;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(175, 85);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(158, 23);
            this.Load.TabIndex = 4;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Loadfile_Click);
            // 
            // savefile
            // 
            this.savefile.Location = new System.Drawing.Point(16, 87);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(153, 21);
            this.savefile.TabIndex = 3;
            this.savefile.Text = "Save";
            this.savefile.UseVisualStyleBackColor = true;
            this.savefile.Click += new System.EventHandler(this.filepath_Click);
            // 
            // PortugueseKey
            // 
            this.PortugueseKey.Location = new System.Drawing.Point(89, 47);
            this.PortugueseKey.Name = "PortugueseKey";
            this.PortugueseKey.Size = new System.Drawing.Size(245, 20);
            this.PortugueseKey.TabIndex = 2;
            // 
            // EnglishKey
            // 
            this.EnglishKey.Location = new System.Drawing.Point(89, 18);
            this.EnglishKey.Name = "EnglishKey";
            this.EnglishKey.Size = new System.Drawing.Size(245, 20);
            this.EnglishKey.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileLoaded
            // 
            this.fileLoaded.AutoSize = true;
            this.fileLoaded.Location = new System.Drawing.Point(16, 121);
            this.fileLoaded.Name = "fileLoaded";
            this.fileLoaded.Size = new System.Drawing.Size(26, 13);
            this.fileLoaded.TabIndex = 6;
            this.fileLoaded.Text = "File:";
            // 
            // LanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 175);
            this.Controls.Add(this.mark);
            this.Name = "LanguageForm";
            this.Text = "Language Editor";
            this.mark.ResumeLayout(false);
            this.mark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox mark;
        private System.Windows.Forms.TextBox PortugueseKey;
        private System.Windows.Forms.TextBox EnglishKey;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button savefile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fileLoaded;
    }
}

