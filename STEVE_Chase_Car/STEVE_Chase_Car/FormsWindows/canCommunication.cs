using STEVE_Chase_Car.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STEVE_Chase_Car.FormsWindows
{
    public partial class canCommunication : Form
    {
        private CANinterfaceControls canControls = new CANinterfaceControls();

        public canCommunication()
        {
            InitializeComponent();
        }

        private void dev_CANalyst_btnConnect_Click(object sender, EventArgs e)
        {
            canControls.CanConnect(0, "00000000", "FFFFFFFF", "03", "1C", 0, 0);
            canControls.StartCan();
        }

        private void dev_CANalyst_btnDisconnect_Click(object sender, EventArgs e)
        {
            canControls.StopCan();
        }

        private void dev_CANalyst_btnSend_Click(object sender, EventArgs e)
        {
            canControls.CanTransmit(0, 0, 0x0, 0, "00 01 02 03 04 05 06 07 ");
        }

        public void dev_CANalyst_Console_Put(string text)
        {
            dev_CANalyst_Console.Text += text + '\n';
        }
    }
}
