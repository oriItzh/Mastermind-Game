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
    public partial class GamePin : UserControl
    {
        public GamePin()
        {
            m_Pin = new List<Color>();
            InitializeComponent();
            InitializeVisualPin();
        }

        public void InitializeVisualPin()
        {
            m_VisualizablePin = new List<PictureBox>();

            foreach (var VARIABLE in Controls)
            {
                if (VARIABLE is PictureBox PictureBox)
                {
                    m_VisualizablePin.Add(PictureBox);
                }
            }
        }

        public void Display()
        {
            if (m_VisualizablePin.Count != m_Pin.Count)
            {
                //Problem
            }
            else
            {
                for (int i = 0; i < m_Pin.Count; i++)
                {
                    m_VisualizablePin[i].BackColor = m_Pin[i];
                }
            }
        }

        public void Hide()
        {
            foreach (PictureBox pictureBox in Controls)
            {
                pictureBox.BackColor = Color.Black;
            }
        }
    }
}
