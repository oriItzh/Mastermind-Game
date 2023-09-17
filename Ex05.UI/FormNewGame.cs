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
    public partial class FormNewGame : Form
    {
        public FormNewGame()
        {
            InitializeComponent();
        }

        public FormNewGame(string i_Message) : this()
        {
            textBoxFixedMssg.Text = i_Message;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
