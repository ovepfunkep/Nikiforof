using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static UsingDLLOnWF.Dll1ExportedFunctions;

namespace UsingDLLOnWF
{
    public partial class Addition : Form
    {
        public Addition(Form form)
        {
            InitializeComponent();
            formParent = form;
        }

        Form formParent;

        private void BTFind_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TextBoxVal1.Text.ToString(), out int value1)
                && int.TryParse(TextBoxVal2.Text.ToString(), out int value2))
            {
                AdditionC additionC = (AdditionC)InitFromLibrary(mainPath, "AdditionC", typeof(AdditionC));
                BTFind.Text = additionC(value1, value2).ToString();
            }
        }

        private void Addition_FormClosed(object sender, FormClosedEventArgs e)
        {
            formParent.Show();
        }
    }
}
