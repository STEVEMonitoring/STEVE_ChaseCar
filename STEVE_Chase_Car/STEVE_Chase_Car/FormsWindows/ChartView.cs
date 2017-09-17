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
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace STEVE_Chase_Car.FormsWindows
{
    public partial class ChartView : Form
    {

        public DatabaseControls DbControls;

        public ChartView()
        {
            InitializeComponent();
        }

        private void loadGraphData()
        {
            string source = "BMS_PDO1";
            string data = chartTreeView.SelectedNode.Text;

            databaseChart.DataSource = sTEVEDatabaseDataSetBindingSource;
            // Specify a connection string. Replace the given value with a 
            // valid connection string for a Northwind SQL Server sample
            // database accessible to your system.
            String connectionString = DbControls.DBconnectionSting;
            String selectCommand = "select Time, " + data + " from " + source;

            // Create a new data adapter based on the specified query.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            sTEVEDatabaseDataSetBindingSource.DataSource = table;

            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = data,
                Color = Color.Blue,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                XValueMember = "Time",
                YValueMembers = data,
                ChartType = SeriesChartType.Line
            };

            databaseChart.Series.Add(series1);
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            loadGraphData();
        }

    }
}
