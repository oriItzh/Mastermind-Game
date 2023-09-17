namespace Ex05.UI
{
    public partial class FormColors : Form
    {
        private Button m_lastClickedButton;

        public Button LastClickedButton
        {
            get
            {
                return m_lastClickedButton;
            }
        }
        public FormColors()
        {
            //buttonColors = new List<ButtonColors>();
            InitializeComponent();
            //CreateButtons();
            SetButtonsProperties();
        }

        //private void CreateButtons()
        //{
        //    SuspendLayout();
        //    int xPos = k_InitialXLoc;
        //    int yPos = k_InitialYLoc;

        //    for (int i = 0; i < k_NumOfColorsInARow; i++)
        //    {
        //        xPos = k_InitialXLoc;
        //        for (int j = 0; j < k_NumOfColorsInARow; ++j)
        //        {
        //            var bc = new ButtonColors();
        //            bc.Location = new Point(xPos, yPos);
        //            bc.Size = new Size(k_ButtonWidth, k_ButtonHeight);
        //            bc.TabIndex = buttonColors.Count;
        //            bc.Name = String.Format("buttonColors{0}", buttonColors.Count);
        //            bc.UseVisualStyleBackColor = true;
        //            bc.SelectedButton = null;

        //            xPos += k_ButtonWidth + k_ButtonHorizontalGap;

        //            buttonColors.Add(bc);
        //            Controls.Add(bc);
        //        }

        //        yPos += k_ButtonHeight + k_BottonVerticalGap;
        //    }
        //    ResumeLayout(false);
        //}

        private void SetButtonsProperties()
        {
            int i = 0;
            foreach (Button button in Controls)
            {
                button.BackColor = sr_optionalColors[i++];
                button.Click += Button_Click;
                //Controls.Add(button);
            }
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button buttonColor = sender as Button;
            if (buttonColor == null)
            {
                throw new ArgumentNullException("Bad casting of a non button");
            }
            m_ColorResult = buttonColor.BackColor;
            buttonColor.Text = "✗";
            buttonColor.Font = new Font("Arial", 40);
            buttonColor.Enabled = false;
            m_lastClickedButton = buttonColor;
            DialogResult = DialogResult.OK;
        }

    }
}
