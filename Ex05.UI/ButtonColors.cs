using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.UI
{
    public class ButtonColors : Button
    {
        public const int k_SizeOfButton = 50;

        //public ButtonColors()
        //{
        //    m_Color = null;
        //    InitializeComponent();
        //}

        //private void InitializeComponent()
        //{
        //    SuspendLayout();
        //    // 
        //    // ButtonColors
        //    // 
        //    Size = new Size(50, 50);
        //    ResumeLayout(false);
        //}

        public Color? Color { get; set;  }

        public Button? SelectedButton { get; set; }

    }
}
