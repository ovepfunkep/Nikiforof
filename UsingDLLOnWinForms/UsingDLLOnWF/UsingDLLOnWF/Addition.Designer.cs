
namespace UsingDLLOnWF
{
    partial class Addition
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
            this.TextBoxVal2 = new System.Windows.Forms.TextBox();
            this.TextBoxVal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxVal2
            // 
            this.TextBoxVal2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxVal2.Location = new System.Drawing.Point(66, 98);
            this.TextBoxVal2.Name = "TextBoxVal2";
            this.TextBoxVal2.Size = new System.Drawing.Size(100, 34);
            this.TextBoxVal2.TabIndex = 0;
            // 
            // TextBoxVal1
            // 
            this.TextBoxVal1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxVal1.Location = new System.Drawing.Point(66, 34);
            this.TextBoxVal1.Name = "TextBoxVal1";
            this.TextBoxVal1.Size = new System.Drawing.Size(100, 34);
            this.TextBoxVal1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // BTFind
            // 
            this.BTFind.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTFind.Location = new System.Drawing.Point(66, 177);
            this.BTFind.Name = "BTFind";
            this.BTFind.Size = new System.Drawing.Size(100, 64);
            this.BTFind.TabIndex = 2;
            this.BTFind.Text = "=";
            this.BTFind.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTFind.UseVisualStyleBackColor = true;
            this.BTFind.Click += new System.EventHandler(this.BTFind_Click);
            // 
            // Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 267);
            this.Controls.Add(this.BTFind);
            this.Controls.Add(this.TextBoxVal1);
            this.Controls.Add(this.TextBoxVal2);
            this.Controls.Add(this.label1);
            this.Name = "Addition";
            this.Text = "Addition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Addition_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxVal2;
        private System.Windows.Forms.TextBox TextBoxVal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTFind;
    }
}