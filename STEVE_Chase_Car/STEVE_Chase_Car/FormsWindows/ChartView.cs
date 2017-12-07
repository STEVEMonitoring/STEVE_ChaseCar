using System;
using System.Collections;
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
using System.Globalization;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace STEVE_Chase_Car.FormsWindows
{
    public partial class ChartView : Form
    {

        public DatabaseControls DbControls;

        private ArrayList chartList = new ArrayList();
        Point? prevPosition = null;
        ToolTip tooltip = new ToolTip();


        public ChartView()
        {
            InitializeComponent();
            databaseChart.Legends.Clear();
            ZoomToggle(true);
        }

        private void chartInit()
        {
            
        }


        private void nodeClick()
        {

        }



        private void loadGraphData(string data)
        {
            try
            {
                this.databaseChart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                this.databaseChart.ChartAreas[0].AxisY.ScaleView.ZoomReset();

                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString = "server=.\\SQLEXPRESS;Trusted_Connection=yes;database=STEVE_database;connection timeout=5;";

                String selectCommand = "select Time, [" + data + "]" + " from " + chartTreeView.SelectedNode.Parent.Text;

                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                sTEVEDatabaseDataSetBindingSource.DataSource = table;

                databaseChart.Series.RemoveAt(0);

                databaseChart.Series.Add(data);
                databaseChart.Series[data].XValueMember = "Time";
                databaseChart.Series[data].YValueMembers = data;
                databaseChart.Series[data].ChartType = SeriesChartType.Line;
                databaseChart.Series[data].BorderWidth = 5;
                databaseChart.DataSource = table;
                databaseChart.DataBind();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           

        }

        private void chartTreeView_DoubleClick(object sender, EventArgs e)
        {
            if(chartTreeView.SelectedNode.Nodes.Count == 0)
            {
                loadGraphData(this.chartTreeView.SelectedNode.Name.ToString());
            }
            
        }

        private void ZoomToggle(bool Enabled)
        {
            // Enable range selection and zooming end user interface
            this.databaseChart.ChartAreas[0].CursorX.IsUserEnabled = Enabled;
            this.databaseChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = Enabled;
            this.databaseChart.ChartAreas[0].CursorX.Interval = 0;
            this.databaseChart.ChartAreas[0].AxisX.ScaleView.Zoomable = Enabled;
            this.databaseChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            this.databaseChart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            this.databaseChart.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 0;

            this.databaseChart.ChartAreas[0].CursorY.IsUserEnabled = Enabled;
            this.databaseChart.ChartAreas[0].CursorY.IsUserSelectionEnabled = Enabled;
            this.databaseChart.ChartAreas[0].CursorY.Interval = 0;
            this.databaseChart.ChartAreas[0].AxisY.ScaleView.Zoomable = Enabled;
            this.databaseChart.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;
            this.databaseChart.ChartAreas[0].AxisY.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            this.databaseChart.ChartAreas[0].AxisY.ScaleView.SmallScrollMinSize = 0;
            if (Enabled == false)
            {
                //Remove the cursor lines
                this.databaseChart.ChartAreas[0].CursorX.SetCursorPosition(double.NaN);
                this.databaseChart.ChartAreas[0].CursorY.SetCursorPosition(double.NaN);
            }
        }

        private void databaseChart_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = databaseChart.HitTest(pos.X, pos.Y, false,
                ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 2 &&
                            Math.Abs(pos.Y - pointYPixel) < 2)
                        {

                            tooltip.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.databaseChart,
                                pos.X, pos.Y - 15);
                        }
                    }
                }
            }
        }
    }
}
