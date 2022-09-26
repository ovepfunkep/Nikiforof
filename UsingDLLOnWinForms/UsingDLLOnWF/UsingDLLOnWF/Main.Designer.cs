
namespace UsingDLLOnWF
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBChooseFun = new System.Windows.Forms.ComboBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBChooseFun
            // 
            this.CBChooseFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBChooseFun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBChooseFun.FormattingEnabled = true;
            this.CBChooseFun.Location = new System.Drawing.Point(93, 34);
            this.CBChooseFun.Name = "CBChooseFun";
            this.CBChooseFun.Size = new System.Drawing.Size(203, 36);
            this.CBChooseFun.TabIndex = 0;
            this.CBChooseFun.SelectedIndexChanged += new System.EventHandler(this.CBChooseFun_SelectedIndexChanged);
            // 
            // BtnGo
            // 
            this.BtnGo.Enabled = false;
            this.BtnGo.Location = new System.Drawing.Point(93, 87);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(203, 53);
            this.BtnGo.TabIndex = 1;
            this.BtnGo.Text = "Go!";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 164);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.CBChooseFun);
            this.Name = "Main";
            this.Text = "Choose function";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBChooseFun;
        private System.Windows.Forms.Button BtnGo;
    }
}

