using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void ConfirmClick(object sender, EventArgs e)
        {
            if (this.PrimaryTextBox.Text.Length < 1)
            {
                this.TextError.SetError(this.PrimaryTextBox, "Preencha o campo");
            }
            else
            {
                this.TextError.SetError(this.PrimaryTextBox, String.Empty);
            }

        }
    }
}
