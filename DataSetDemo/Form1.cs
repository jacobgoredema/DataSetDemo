using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet dataSet;
        DataTable employeeDataTable;
        SqlDataAdapter employeeSqlDataAdpater;




        private void Form1_Load(object sender, EventArgs e)
        {
            dataSet = new DataSet();
            employeeSqlDataAdpater = new SqlDataAdapter("Select EmployeeId,Name,Salary FROM Employee", DbHelper.ConnectionString);
            employeeSqlDataAdpater.Fill(dataSet, "Employee");
            employeeDataTable = dataSet.Tables["Employee"];

            dataGridView.DataSource = employeeDataTable;




        }
    }
}
