using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payrollmanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            string connectionString = @"server = .\SQLEXPRESS; database = payrollmanagement; integrated security = SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string Employee_ID = employeeIDtextBox.Text;
            string Employee_Name = employeeNametextBox.Text;
            string Basic_Salary = BasicSalarytextBox.Text;
            double House_Rant;
            House_Rant = (Convert.ToDouble(Basic_Salary))*20/100;
            double Medical;
            Medical = (Convert.ToDouble(Basic_Salary))*15/100;
            double Tax;
            Tax = (Convert.ToDouble(Basic_Salary))*5/100;
            double Total_Salary;
            Total_Salary = Convert.ToDouble(Basic_Salary) + House_Rant + Medical - Tax;


            string insertQuery = "insert into payroll(Employee_ID,Employee_Name,Basic_Salary,House_Rant,Medical,Tax,Toatal_Salary)values('" + Employee_ID + "','" + Employee_Name + "','" + Basic_Salary + "','" + House_Rant + "','" + Medical + "','" + Tax + "','" + Total_Salary + "')";

            SqlCommand command = new SqlCommand(insertQuery, connection);
            int effectedRows = command.ExecuteNonQuery();

            MessageBox.Show(effectedRows + " rows inserted.");

            connection.Close();

           
        }

        private void displaybutton_Click(object sender, EventArgs e)
        {
            //string[] Employee_ID = new string[10];
            //string[] Employee_Name = new string[10];
           // string[] Basic_Salary = new string[10];
            //string[] Medical = new string[10];
            //string[] Tax = new string[10];
           // string[] Total_Salary = new string[10];


            string connectionString = @"server = .\sqlexpress; database = payrollmanagement;integrated security = SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string tableSql = "SELECT * FROM payroll";
            SqlCommand selectAllTableSqlCommand = new SqlCommand(tableSql, connection);
            SqlDataReader tableReader = selectAllTableSqlCommand.ExecuteReader();
            int j = 0;

            //var displayData = "";
            if (tableReader != null) while (tableReader.Read())
                {

                    payrolldataGridView.Rows.Add(tableReader[0].ToString(), tableReader[1].ToString(), tableReader[2].ToString(), tableReader[3].ToString(), tableReader[4].ToString(), tableReader[5].ToString(), tableReader[6].ToString());
                }
            tableReader.Close();
            connection.Close(); 
        }
    }
}
