
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
            this.CBLanguage = new System.Windows.Forms.ComboBox();
            this.CBPlace = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CBChooseFun
            // 
            this.CBChooseFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBChooseFun.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBChooseFun.FormattingEnabled = true;
            this.CBChooseFun.Location = new System.Drawing.Point(29, 34);
            this.CBChooseFun.Name = "CBChooseFun";
            this.CBChooseFun.Size = new System.Drawing.Size(203, 36);
            this.CBChooseFun.TabIndex = 0;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(29, 87);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(326, 44);
            this.BtnGo.TabIndex = 1;
            this.BtnGo.Text = "Go!";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // CBLanguage
            // 
            this.CBLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLanguage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBLanguage.FormattingEnabled = true;
            this.CBLanguage.Items.AddRange(new object[] {
            "C++",
            "Lazarus"});
            this.CBLanguage.Location = new System.Drawing.Point(238, 34);
            this.CBLanguage.Name = "CBLanguage";
            this.CBLanguage.Size = new System.Drawing.Size(117, 36);
            this.CBLanguage.TabIndex = 2;
            // 
            // CBPlace
            // 
            this.CBPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPlace.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CBPlace.FormattingEnabled = true;
            this.CBPlace.Items.AddRange(new object[] {
            "Home",
            "VKI"});
            this.CBPlace.Location = new System.Drawing.Point(29, 7);
            this.CBPlace.Name = "CBPlace";
            this.CBPlace.Size = new System.Drawing.Size(127, 21);
            this.CBPlace.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 151);
            this.Controls.Add(this.CBPlace);
            this.Controls.Add(this.CBLanguage);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.CBChooseFun);
            this.Name = "Main";
            this.Text = "Choose function";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBChooseFun;
        private System.Windows.Forms.Button BtnGo;
        public System.Windows.Forms.ComboBox CBLanguage;
        private System.Windows.Forms.ComboBox CBPlace;
    }
}

