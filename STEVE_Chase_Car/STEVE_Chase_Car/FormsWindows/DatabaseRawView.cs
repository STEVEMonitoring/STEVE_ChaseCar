using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using STEVE_Chase_Car.Code;
using System.Data.SqlClient;

namespace STEVE_Chase_Car.FormsWindows
{
    public partial class DatabaseRawView : Form
    {
        public DatabaseControls DbControls;

        public DatabaseRawView()
        {
            InitializeComponent();
            CBsourceSelect.SelectedIndex = 0;
        }

        private void DatabaseRawView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTEVE_DatabaseDataSet.BMS_PDO1' table. You can move, or remove it, as needed.
            //this.bMS_PDO1TableAdapter.Fill(this.sTEVE_DatabaseDataSet.BMS_PDO1);

        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            DbControls.ConnectionOk();
            string sourceSelection = CBsourceSelect.Text;
            loadDatagridData(sourceSelection);

        }

        private void loadDatagridData(string source)
        {
            try
            {
                steveDatabaseView.DataSource = sTEVEDatabaseDataSetBindingSource;
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = DbControls.DBconnectionSting;
                String selectCommand = "select * from " + source; 

                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                sTEVEDatabaseDataSetBindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                steveDatabaseView.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                steveDatabaseView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                                "connectionString variable with a connection string that is " +
                                "valid for your system.");
            }
        }
    }
}
