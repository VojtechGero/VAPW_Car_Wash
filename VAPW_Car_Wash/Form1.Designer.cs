namespace VAPW_Car_Wash
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
            pictureBox1 = new PictureBox();
            InDoors = new Panel();
            OutGate = new Panel();
            InSemafor = new Panel();
            OutSemafor = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CarHereButton
            // 
            CarHereButton.Location = new Point(12, 16);
            CarHereButton.Name = "CarHereButton";
            CarHereButton.Size = new Size(75, 23);
            CarHereButton.TabIndex = 0;
            CarHereButton.Text = "Drive up";
            CarHereButton.UseVisualStyleBackColor = true;
            // 
            // FullButton
            // 
            FullButton.AutoSize = true;
            FullButton.Location = new Point(107, 41);
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
            BasicButton.Location = new Point(107, 66);
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
            label1.Location = new Point(107, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "Wash style";
            // 
            // QuickButton
            // 
            QuickButton.AutoSize = true;
            QuickButton.Location = new Point(107, 91);
            QuickButton.Name = "QuickButton";
            QuickButton.Size = new Size(56, 19);
            QuickButton.TabIndex = 4;
            QuickButton.Text = "Quick";
            QuickButton.UseVisualStyleBackColor = true;
            QuickButton.Click += QuickButton_Click;
            // 
            // CarEntryButton
            // 
            CarEntryButton.Location = new Point(201, 16);
            CarEntryButton.Name = "CarEntryButton";
            CarEntryButton.Size = new Size(75, 23);
            CarEntryButton.TabIndex = 5;
            CarEntryButton.Text = "Enter";
            CarEntryButton.UseVisualStyleBackColor = true;
            // 
            // LeaveButton
            // 
            LeaveButton.Location = new Point(584, 16);
            LeaveButton.Name = "LeaveButton";
            LeaveButton.Size = new Size(75, 23);
            LeaveButton.TabIndex = 6;
            LeaveButton.Text = "Leave";
            LeaveButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SadCar;
            pictureBox1.Location = new Point(23, 246);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // InDoors
            // 
            InDoors.BackColor = SystemColors.AppWorkspace;
            InDoors.Location = new Point(286, 162);
            InDoors.Name = "InDoors";
            InDoors.Size = new Size(15, 212);
            InDoors.TabIndex = 8;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 409);
            Controls.Add(panel1);
            Controls.Add(OutSemafor);
            Controls.Add(InSemafor);
            Controls.Add(OutGate);
            Controls.Add(InDoors);
            Controls.Add(pictureBox1);
            Controls.Add(LeaveButton);
            Controls.Add(CarEntryButton);
            Controls.Add(QuickButton);
            Controls.Add(label1);
            Controls.Add(BasicButton);
            Controls.Add(FullButton);
            Controls.Add(CarHereButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Panel InDoors;
        private Panel OutGate;
        private Panel InSemafor;
        private Panel OutSemafor;
        private Panel panel1;
    }
}
