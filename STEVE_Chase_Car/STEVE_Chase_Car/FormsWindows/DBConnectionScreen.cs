using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STEVE_Chase_Car.Code;
using static System.Windows.Forms.MessageBox;


namespace STEVE_Chase_Car
{
    public partial class DBConnectionScreen : Form
    {
        public DBConnectionScreen()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            DatabaseControls dbControls = new DatabaseControls(@TBserver.Text, TBdatabase.Text);

            /**************************Just for testing ***************************/
            if (CBjustTesting.Checked)
            {
                this.Hide();
                Form1 newForm1 = new Form1();
                newForm1.mainScreenDbControl = dbControls;
                newForm1.Show();
                return;
            }
            /********************************************************************/

            if (!dbControls.ConnectionOk())
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to create a database with the name " + TBdatabase.Text, "SQL Database", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dbControls.createDatabase())
                    {
                        this.Hide();
                        Form1 newForm1 = new Form1();
                        newForm1.mainScreenDbControl = dbControls;
                        newForm1.Show();            
                    }
                }
            }
            else
            {
                //MessageBox.Show("Connection Established!", "SQL Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 newForm1 = new Form1();
                newForm1.mainScreenDbControl = dbControls;
                newForm1.Show();
            }
        }
    }
}
