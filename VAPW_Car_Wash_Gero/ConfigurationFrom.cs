using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAPW_Car_Wash_Gero
{
    public partial class ConfigurationFrom : Form
    {
        public bool EventsSelected { get; set; } = true;
        public ConfigurationFrom(bool eventsSelected)
        {
            InitializeComponent();
            if (eventsSelected)
            {
                EventButton.Checked = true;
            }
            else TimerButton.Checked = true;
        }

        private void killAll()
        {
            EventButton.Checked = false;
            TimerButton.Checked = false;
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            killAll();
            EventButton.Checked = true;
            EventsSelected = true;
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            killAll();
            TimerButton.Checked = true;
            EventsSelected = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
