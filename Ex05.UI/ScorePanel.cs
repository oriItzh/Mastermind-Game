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
        public class BingoCount
        {
            public int Bool { get; set; }
            public int Pgia { get; set; }
        }

        public BingoCount BoolPgia { get;}

        public ScorePanel()
        {
            InitializeComponent();
        }

        public void DisplayResult()
        {
            int countBool = m_BingoCount.Bool;
            int countPgia = m_BingoCount.Pgia;

            for (int i = 0; i < countBool + countPgia; i++)
            {
                Controls[i].BackColor = i < countBool ? Color.Black : Color.Yellow;
            }
        }
    }
}
