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
            DatabaseControls dbControls = new DatabaseControls(TBserver.Text, TBdatabase.Text, TBuserName.Text, TBpassword.Text);

            if (!dbControls.ConnectionOk())
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to create a database with the name " + TBdatabase.Text, "SQL Database", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    dbControls.createDatabase();
                }
            }
            else
            {
                MessageBox.Show("Connection Established!", "SQL Database", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
