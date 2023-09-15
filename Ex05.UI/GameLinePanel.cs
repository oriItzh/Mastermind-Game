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
    public partial class GameLinePanel : UserControl
    {
        public GameLinePanel()
        {
            //m_correctGuess = correctGuess;
            r_FormColors = new FormColors();
            InitializeComponent();
            SetButtonColors();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {

            if (UpdateTurnGuess())
            {
                DisableAllButtons();
                OnSubmitted();
            }
        }

        private bool UpdateTurnGuess()
        {
            m_TurnGuess = new List<Color>();

            foreach (Control control in Controls)
            {
                if (control is ButtonColors buttonColors)
                {
                    if (buttonColors.Color == null)
                    {
                        return false;
                    }
                    m_TurnGuess.Add((Color)buttonColors.Color);
                }
            }

            return true;
        }

        protected virtual void OnSubmitted()
        {
            if (Submitted != null)
            {
                Submitted.Invoke(this, EventArgs.Empty);
            }
        }

        public void DisableAllButtons()
        {
            foreach (Control button in Controls)
            {
                if (button is Button)
                {
                    button.Enabled = false;
                }
            }
        }

        public void EnableAllButtons()
        {
            foreach (Control button in Controls)
            {
                if (button is Button)
                {
                    button.Enabled = true;
                }
            }
        }

        private void SetButtonColors()
        {
            foreach (Control button in Controls)
            {
                if (button is ButtonColors)
                {
                    button.Click += ButtonColors_Click;
                }
            }
        }

        private void ButtonColors_Click(object? sender, EventArgs e)
        {
            if (sender is ButtonColors buttonColors)
            {
                if (r_FormColors.ShowDialog() == DialogResult.OK)
                {
                    if (buttonColors.SelectedButton != null)
                    {
                        buttonColors.SelectedButton.Enabled = true;
                        buttonColors.SelectedButton.Text = null;
                    }
                    buttonColors.BackColor = r_FormColors.ChosenColor;
                    buttonColors.Color = r_FormColors.ChosenColor;
                    buttonColors.SelectedButton = r_FormColors.LastClickedButton;
                }
            }
        }

        private void GameLinePanel_Load(object sender, EventArgs e)
        {

        }

        private void buttonColors5_Click(object sender, EventArgs e)
        {

        }
    }
}
