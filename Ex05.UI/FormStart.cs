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
    public partial class FormStart : Form
    {
        public const int k_MinNumOfChances = 4;
        public const int k_MaxNumOfChances = 10;

        public FormStart()
        {
            InitializeComponent();
            SetButtonCounter();
        }

        private void SetButtonCounter()
        {
            m_ButtonChancesCounter.Text = string.Format(
                "Number of chances: {0}", m_NumOfChances);
            m_ButtonStart.Click += ButtonStart_Click;
            m_ButtonChancesCounter.Click += ButtonChancesCounter_Click;
        }

        public int NumOfChances
        {
            get { return m_NumOfChances; }
        }

        private void ButtonChancesCounter_Click(object? sender, EventArgs e)
        {
            Button thisButton = sender as Button;
            int valueToBeModuled = k_MaxNumOfChances + 1;

            m_NumOfChances++;
            m_NumOfChances = m_NumOfChances % valueToBeModuled
                             + k_MinNumOfChances * (m_NumOfChances / valueToBeModuled);
            thisButton.Text = string.Format(
                "Number of chances: {0}", m_NumOfChances);
        }

        private void ButtonStart_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }
    }
}
