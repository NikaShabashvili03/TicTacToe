namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TicTacLogo = new PictureBox();
            startGameBtn = new Button();
            optionsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TicTacLogo).BeginInit();
            SuspendLayout();
            // 
            // TicTacLogo
            // 
            TicTacLogo.BackgroundImage = Properties.Resources.tic__tac_toe_;
            TicTacLogo.BackgroundImageLayout = ImageLayout.Stretch;
            TicTacLogo.Dock = DockStyle.Fill;
            TicTacLogo.Location = new Point(0, 0);
            TicTacLogo.Name = "TicTacLogo";
            TicTacLogo.Size = new Size(418, 448);
            TicTacLogo.TabIndex = 1;
            TicTacLogo.TabStop = false;
            // 
            // startGameBtn
            // 
            startGameBtn.BackColor = Color.White;
            startGameBtn.Cursor = Cursors.Hand;
            startGameBtn.FlatAppearance.BorderColor = Color.White;
            startGameBtn.FlatAppearance.BorderSize = 0;
            startGameBtn.FlatAppearance.MouseDownBackColor = Color.White;
            startGameBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(188, 219, 249);
            startGameBtn.FlatStyle = FlatStyle.Flat;
            startGameBtn.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startGameBtn.ForeColor = SystemColors.ControlText;
            startGameBtn.Location = new Point(48, 360);
            startGameBtn.Name = "startGameBtn";
            startGameBtn.Size = new Size(314, 56);
            startGameBtn.TabIndex = 4;
            startGameBtn.Text = "Start Game";
            startGameBtn.UseVisualStyleBackColor = false;
            startGameBtn.Click += LoadGame;
            // 
            // optionsBtn
            // 
            optionsBtn.BackColor = Color.Transparent;
            optionsBtn.BackgroundImage = Properties.Resources.Settings_icon;
            optionsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            optionsBtn.Cursor = Cursors.Hand;
            optionsBtn.DialogResult = DialogResult.No;
            optionsBtn.FlatAppearance.BorderColor = Color.FromArgb(90, 30, 118);
            optionsBtn.FlatAppearance.BorderSize = 0;
            optionsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 30, 118);
            optionsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 30, 118);
            optionsBtn.FlatStyle = FlatStyle.Flat;
            optionsBtn.ForeColor = Color.Transparent;
            optionsBtn.Location = new Point(368, 368);
            optionsBtn.Name = "optionsBtn";
            optionsBtn.RightToLeft = RightToLeft.No;
            optionsBtn.Size = new Size(40, 39);
            optionsBtn.TabIndex = 0;
            optionsBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            optionsBtn.UseVisualStyleBackColor = false;
            optionsBtn.Click += LoadOptions;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(90, 30, 118);
            ClientSize = new Size(418, 448);
            Controls.Add(optionsBtn);
            Controls.Add(startGameBtn);
            Controls.Add(TicTacLogo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosed += MenuScreenClose;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TicTacLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox TicTacLogo;
        private Button startGameBtn;
        private Button optionsBtn;
    }
}
