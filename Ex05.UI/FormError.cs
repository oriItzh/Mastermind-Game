using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.UI
{
    public partial class FormError : Form
    {
        public FormError()
        {
            InitializeComponent();
        }

        public FormError(string i_Message) : this()
        {
            errorProvider1.SetError(this, i_Message);
            textBox1.Text = i_Message;
        }
    }
}
