namespace VAPW_Car_Wash_Gero
{
    partial class ConfigurationFrom
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
            EventButton = new RadioButton();
            TimerButton = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // EventButton
            // 
            EventButton.AutoSize = true;
            EventButton.Location = new Point(33, 18);
            EventButton.Name = "EventButton";
            EventButton.Size = new Size(54, 19);
            EventButton.TabIndex = 0;
            EventButton.Text = "Event";
            EventButton.UseVisualStyleBackColor = true;
            EventButton.Click += EventButton_Click;
            // 
            // TimerButton
            // 
            TimerButton.AutoSize = true;
            TimerButton.Location = new Point(33, 43);
            TimerButton.Name = "TimerButton";
            TimerButton.Size = new Size(55, 19);
            TimerButton.TabIndex = 1;
            TimerButton.Text = "Timer";
            TimerButton.UseVisualStyleBackColor = true;
            TimerButton.Click += TimerButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(33, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ConfigurationFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 125);
            Controls.Add(button1);
            Controls.Add(TimerButton);
            Controls.Add(EventButton);
            Name = "ConfigurationFrom";
            Text = "ConfigurationFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton EventButton;
        private RadioButton TimerButton;
        private Button button1;
    }
}