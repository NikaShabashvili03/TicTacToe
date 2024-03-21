using System.Runtime.InteropServices;

namespace TicTacToe
{
    partial class OptionsScreen
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


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse
        );


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsScreen));
            textBox1 = new TextBox();
            SubmitOptions = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BackToMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // SubmitOptions
            // 
            SubmitOptions.BackColor = Color.White;
            SubmitOptions.Cursor = Cursors.Hand;
            SubmitOptions.FlatAppearance.BorderSize = 0;
            SubmitOptions.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 190, 0);
            SubmitOptions.FlatStyle = FlatStyle.Flat;
            SubmitOptions.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Bold);
            SubmitOptions.ForeColor = SystemColors.ControlText;
            SubmitOptions.Location = new Point(48, 360);
            SubmitOptions.Name = "SubmitOptions";
            SubmitOptions.Size = new Size(314, 56);
            SubmitOptions.TabIndex = 1;
            SubmitOptions.Text = "Submit";
            SubmitOptions.UseVisualStyleBackColor = false;
            SubmitOptions.Click += SubmitOptions_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.tic__tac_toe_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 448);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 14);
            label1.TabIndex = 4;
            label1.Text = "Length of the game table";
            // 
            // BackToMenu
            // 
            BackToMenu.BackColor = Color.Transparent;
            BackToMenu.BackgroundImage = Properties.Resources.backarrow;
            BackToMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BackToMenu.Cursor = Cursors.Hand;
            BackToMenu.DialogResult = DialogResult.No;
            BackToMenu.FlatAppearance.BorderColor = Color.FromArgb(90, 30, 118);
            BackToMenu.FlatAppearance.BorderSize = 0;
            BackToMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(90, 30, 118);
            BackToMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 30, 118);
            BackToMenu.FlatStyle = FlatStyle.Flat;
            BackToMenu.ForeColor = Color.Transparent;
            BackToMenu.Location = new Point(368, 369);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.RightToLeft = RightToLeft.No;
            BackToMenu.Size = new Size(40, 39);
            BackToMenu.TabIndex = 5;
            BackToMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            BackToMenu.UseVisualStyleBackColor = false;
            BackToMenu.Click += BackToMenu_Click;
            // 
            // OptionsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 30, 118);
            ClientSize = new Size(418, 448);
            Controls.Add(BackToMenu);
            Controls.Add(label1);
            Controls.Add(SubmitOptions);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "OptionsScreen";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Options";
            FormClosed += CloseOptionsScreen;
            Load += OptionsScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button SubmitOptions;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BackToMenu;
    }
}