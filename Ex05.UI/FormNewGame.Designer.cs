namespace Ex05.UI
{
    partial class FormNewGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonYes = new Button();
            buttonNo = new Button();
            labelUserMsg = new Label();
            textBoxFixedMssg = new TextBox();
            SuspendLayout();
            // 
            // buttonYes
            // 
            buttonYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonYes.Location = new Point(744, 135);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(148, 73);
            buttonYes.TabIndex = 0;
            buttonYes.Text = "Yes";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNo.Location = new Point(925, 135);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(148, 73);
            buttonNo.TabIndex = 0;
            buttonNo.Text = "No";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // labelUserMsg
            // 
            labelUserMsg.AutoSize = true;
            labelUserMsg.Location = new Point(30, 143);
            labelUserMsg.Name = "labelUserMsg";
            labelUserMsg.Size = new Size(598, 48);
            labelUserMsg.TabIndex = 1;
            labelUserMsg.Text = "Would you like to start a new game?";
            // 
            // textBoxFixedMssg
            // 
            textBoxFixedMssg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFixedMssg.Location = new Point(12, 19);
            textBoxFixedMssg.Name = "textBoxFixedMssg";
            textBoxFixedMssg.Size = new Size(1062, 55);
            textBoxFixedMssg.TabIndex = 2;
            // 
            // FormNewGame
            // 
            AcceptButton = buttonYes;
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonNo;
            ClientSize = new Size(1090, 219);
            Controls.Add(textBoxFixedMssg);
            Controls.Add(labelUserMsg);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewGame";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNewGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonYes;
        private Button buttonNo;
        private Label labelUserMsg;
        private TextBox textBoxFixedMssg;
    }
}