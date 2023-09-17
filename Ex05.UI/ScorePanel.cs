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
    public partial class ScorePanel : UserControl
    {
        private static readonly Color k_CowColor = Color.Yellow;
        private static readonly Color k_BullColor = Color.Black;

        public class ScoreBoard
        {
            public int Bull { get; set; }
            public int Cow { get; set; }
        }

        public ScoreBoard ScoreCounter => r_ScoreBoard;

        public ScorePanel()
        {
            InitializeComponent();
            m_pictureBoxes = new List<PictureBox>()
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4
            };
            r_ScoreBoard = new ScoreBoard();
        }

        public void DisplayResult()
        {
            int countBull = r_ScoreBoard.Bull;
            int countCow = r_ScoreBoard.Cow;

            for (int i = 0; i < countBull; i++)
            {
                m_pictureBoxes[i].BackColor = k_BullColor;
            }
            for (int i = countBull; i < countBull + countCow; i++)
            {
                m_pictureBoxes[i].BackColor = k_CowColor;
            }
        }
    }
}
