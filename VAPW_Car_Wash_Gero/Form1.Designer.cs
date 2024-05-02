namespace VAPW_Car_Wash_Gero
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
            CarHereButton = new Button();
            FullButton = new RadioButton();
            BasicButton = new RadioButton();
            label1 = new Label();
            QuickButton = new RadioButton();
            CarEntryButton = new Button();
            LeaveButton = new Button();
            Car = new PictureBox();
            InGate = new Panel();
            OutGate = new Panel();
            InSemafor = new Panel();
            OutSemafor = new Panel();
            panel1 = new Panel();
            ErrorLabel = new Label();
            menuStrip1 = new MenuStrip();
            modelConnectionToolStripMenuItem = new ToolStripMenuItem();
            ConnectionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Car).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // CarHereButton
            // 
            CarHereButton.Location = new Point(12, 28);
            CarHereButton.Name = "CarHereButton";
            CarHereButton.Size = new Size(75, 23);
            CarHereButton.TabIndex = 0;
            CarHereButton.Text = "Drive up";
            CarHereButton.UseVisualStyleBackColor = true;
            CarHereButton.Click += CarHereButton_Click;
            // 
            // FullButton
            // 
            FullButton.AutoSize = true;
            FullButton.Location = new Point(107, 53);
            FullButton.Name = "FullButton";
            FullButton.Size = new Size(51, 19);
            FullButton.TabIndex = 1;
            FullButton.Text = "FULL";
            FullButton.UseVisualStyleBackColor = true;
            FullButton.Click += FullButton_Click;
            // 
            // BasicButton
            // 
            BasicButton.AutoSize = true;
            BasicButton.Checked = true;
            BasicButton.Location = new Point(107, 78);
            BasicButton.Name = "BasicButton";
            BasicButton.Size = new Size(52, 19);
            BasicButton.TabIndex = 2;
            BasicButton.TabStop = true;
            BasicButton.Text = "Basic";
            BasicButton.UseVisualStyleBackColor = true;
            BasicButton.Click += BasicButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 32);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Wash style";
            // 
            // QuickButton
            // 
            QuickButton.AutoSize = true;
            QuickButton.Location = new Point(107, 103);
            QuickButton.Name = "QuickButton";
            QuickButton.Size = new Size(56, 19);
            QuickButton.TabIndex = 4;
            QuickButton.Text = "Quick";
            QuickButton.UseVisualStyleBackColor = true;
            QuickButton.Click += QuickButton_Click;
            // 
            // CarEntryButton
            // 
            CarEntryButton.Location = new Point(201, 28);
            CarEntryButton.Name = "CarEntryButton";
            CarEntryButton.Size = new Size(75, 23);
            CarEntryButton.TabIndex = 5;
            CarEntryButton.Text = "Enter";
            CarEntryButton.UseVisualStyleBackColor = true;
            CarEntryButton.Click += CarEntryButton_Click;
            // 
            // LeaveButton
            // 
            LeaveButton.Location = new Point(584, 28);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.Size = new Size(75, 23);
            LeaveButton.TabIndex = 6;
            LeaveButton.Text = "Leave";
            LeaveButton.UseVisualStyleBackColor = true;
            LeaveButton.Click += LeaveButton_Click;
            // 
            // Car
            // 
            Car.Image = Properties.Resources.SadCar;
            Car.Location = new Point(23, 246);
            Car.Name = "Car";
            Car.Size = new Size(150, 130);
            Car.SizeMode = PictureBoxSizeMode.StretchImage;
            Car.TabIndex = 7;
            Car.TabStop = false;
            Car.Visible = false;
            // 
            // InGate
            // 
            InGate.BackColor = SystemColors.AppWorkspace;
            InGate.Location = new Point(286, 162);
            InGate.Name = "InGate";
            InGate.Size = new Size(15, 212);
            InGate.TabIndex = 8;
            // 
            // OutGate
            // 
            OutGate.BackColor = SystemColors.AppWorkspace;
            OutGate.Location = new Point(584, 162);
            OutGate.Name = "OutGate";
            OutGate.Size = new Size(15, 212);
            OutGate.TabIndex = 9;
            // 
            // InSemafor
            // 
            InSemafor.BackColor = Color.Red;
            InSemafor.Location = new Point(226, 135);
            InSemafor.Name = "InSemafor";
            InSemafor.Size = new Size(40, 40);
            InSemafor.TabIndex = 10;
            // 
            // OutSemafor
            // 
            OutSemafor.BackColor = Color.Red;
            OutSemafor.Location = new Point(528, 135);
            OutSemafor.Name = "OutSemafor";
            OutSemafor.Size = new Size(40, 40);
            OutSemafor.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(12, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 17);
            panel1.TabIndex = 12;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 12F);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(397, 27);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(52, 21);
            ErrorLabel.TabIndex = 13;
            ErrorLabel.Text = "label2";
            ErrorLabel.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { modelConnectionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // modelConnectionToolStripMenuItem
            // 
            modelConnectionToolStripMenuItem.Name = "modelConnectionToolStripMenuItem";
            modelConnectionToolStripMenuItem.Size = new Size(116, 20);
            modelConnectionToolStripMenuItem.Text = "Model connection";
            modelConnectionToolStripMenuItem.Click += modelConnectionToolStripMenuItem_Click;
            // 
            // ConnectionLabel
            // 
            ConnectionLabel.AutoSize = true;
            ConnectionLabel.Font = new Font("Segoe UI", 12F);
            ConnectionLabel.ForeColor = Color.Black;
            ConnectionLabel.Location = new Point(12, 162);
            ConnectionLabel.Name = "ConnectionLabel";
            ConnectionLabel.Size = new Size(99, 21);
            ConnectionLabel.TabIndex = 15;
            ConnectionLabel.Text = "Using events";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(ConnectionLabel);
            Controls.Add(ErrorLabel);
            Controls.Add(panel1);
            Controls.Add(OutSemafor);
            Controls.Add(InSemafor);
            Controls.Add(OutGate);
            Controls.Add(InGate);
            Controls.Add(Car);
            Controls.Add(LeaveButton);
            Controls.Add(CarEntryButton);
            Controls.Add(QuickButton);
            Controls.Add(label1);
            Controls.Add(BasicButton);
            Controls.Add(FullButton);
            Controls.Add(CarHereButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Car).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CarHereButton;
        private RadioButton FullButton;
        private RadioButton BasicButton;
        private Label label1;
        private RadioButton QuickButton;
        private Button CarEntryButton;
        private Button LeaveButton;
        private PictureBox Car;
        private Panel InGate;
        private Panel OutGate;
        private Panel InSemafor;
        private Panel OutSemafor;
        private Panel panel1;
        private Label ErrorLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem modelConnectionToolStripMenuItem;
        private Label ConnectionLabel;
    }
}
