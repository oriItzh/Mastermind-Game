namespace Ex05.UI
{
    partial class FormError
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
            buttonOk = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.Location = new Point(410, 173);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(204, 88);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(602, 143);
            textBox1.TabIndex = 1;
            // 
            // FormError
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonOk;
            ClientSize = new Size(628, 276);
            Controls.Add(textBox1);
            Controls.Add(buttonOk);
            Name = "FormError";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private TextBox textBox1;
    }
}