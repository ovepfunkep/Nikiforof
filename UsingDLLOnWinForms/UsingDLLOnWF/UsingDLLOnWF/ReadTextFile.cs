using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UsingDLLOnWF
{
    public partial class ReadTextFile : Form
    {
        public ReadTextFile(Form form)
        {
            InitializeComponent();
            FormParent = form;
        }

        Form FormParent;

        private void ReadTextFile_Deactivate(object sender, EventArgs e)
        {
            FormParent.Show();
        }
    }
}
