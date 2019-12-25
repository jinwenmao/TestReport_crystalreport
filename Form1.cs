using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace TestReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            
            ds.mytable.AddmytableRow("a", "b", "c");
            ds.mytable.AddmytableRow("a", "b", "c");
            ds.mytable.AddmytableRow("a", "b", "c");
            ds.mytable.AddmytableRow("a", "b", "c");

            ReportDocument rDoc1 = new ReportDocument();     
            //DataGridview中的datatable复制到指定的指定DataTable中，为水晶报表提供          
               
            //绑定水晶报表         
            CrystalReport1 cry = new CrystalReport1();      
            cry.Refresh();          
            cry.SetDataSource(ds.Tables[0]);     
            this.crystalReportViewer1.ReportSource = null;      
            this.crystalReportViewer1.ReportSource = cry;         
            this.crystalReportViewer1.RefreshReport();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
