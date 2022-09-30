
namespace UsingDLLOnWF
{
    partial class ReadTextFile
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
            this.TBFilePath = new System.Windows.Forms.TextBox();
            this.BtnFindCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBFilePath
            // 
            this.TBFilePath.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBFilePath.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TBFilePath.Location = new System.Drawing.Point(12, 12);
            this.TBFilePath.Name = "TBFilePath";
            this.TBFilePath.PlaceholderText = "File path...";
            this.TBFilePath.Size = new System.Drawing.Size(547, 34);
            this.TBFilePath.TabIndex = 0;
            // 
            // BtnFindCount
            // 
            this.BtnFindCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFindCount.Location = new System.Drawing.Point(12, 67);
            this.BtnFindCount.Name = "BtnFindCount";
            this.BtnFindCount.Size = new System.Drawing.Size(190, 39);
            this.BtnFindCount.TabIndex = 1;
            this.BtnFindCount.Text = "Line count =";
            this.BtnFindCount.UseVisualStyleBackColor = true;
            this.BtnFindCount.Click += new System.EventHandler(this.BtnFindCount_Click);
            // 
            // ReadTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 127);
            this.Controls.Add(this.BtnFindCount);
            this.Controls.Add(this.TBFilePath);
            this.Name = "ReadTextFile";
            this.Text = "ReadTextFile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReadTextFile_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBFilePath;
        private System.Windows.Forms.Button BtnFindCount;
    }
}