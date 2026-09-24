namespace GUI26092402
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSpringGreen = new Label();
            lblCornflowerBlue = new Label();
            lblHotPink = new Label();
            lblGold = new Label();
            btnExit = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblSpringGreen
            // 
            lblSpringGreen.BackColor = Color.SpringGreen;
            lblSpringGreen.Location = new Point(39, 39);
            lblSpringGreen.Margin = new Padding(30);
            lblSpringGreen.Name = "lblSpringGreen";
            lblSpringGreen.Size = new Size(299, 60);
            lblSpringGreen.TabIndex = 0;
            // 
            // lblCornflowerBlue
            // 
            lblCornflowerBlue.BackColor = Color.CornflowerBlue;
            lblCornflowerBlue.Location = new Point(39, 159);
            lblCornflowerBlue.Margin = new Padding(30);
            lblCornflowerBlue.Name = "lblCornflowerBlue";
            lblCornflowerBlue.Size = new Size(299, 60);
            lblCornflowerBlue.TabIndex = 0;
            // 
            // lblHotPink
            // 
            lblHotPink.BackColor = Color.HotPink;
            lblHotPink.Location = new Point(39, 279);
            lblHotPink.Margin = new Padding(30);
            lblHotPink.Name = "lblHotPink";
            lblHotPink.Size = new Size(299, 60);
            lblHotPink.TabIndex = 0;
            // 
            // lblGold
            // 
            lblGold.BackColor = Color.Gold;
            lblGold.Location = new Point(39, 399);
            lblGold.Margin = new Padding(30);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(299, 60);
            lblGold.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(203, 521);
            btnExit.Margin = new Padding(30);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 60);
            btnExit.TabIndex = 1;
            btnExit.Text = "Kilépés";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(39, 521);
            btnReset.Margin = new Padding(30);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(135, 60);
            btnReset.TabIndex = 1;
            btnReset.Text = "Alaphelyzet";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(377, 620);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(lblGold);
            Controls.Add(lblHotPink);
            Controls.Add(lblCornflowerBlue);
            Controls.Add(lblSpringGreen);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMain";
            Text = "Coloring";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSpringGreen;
        private Label lblCornflowerBlue;
        private Label lblHotPink;
        private Label lblGold;
        private Button btnExit;
        private Button btnReset;
    }
}
