using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace ExcelToSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<Employee> employees = new List<Employee>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Employee employee = new Employee();
                    employee.EmployeeId = Convert.ToInt32(dt.Rows[i]["0"]);
                    employee.FirstName = dt.Rows[i]["First Name"].ToString();
                    employee.LastName = dt.Rows[i]["Last Name"].ToString();
                    employee.Gender = dt.Rows[i]["Gender"].ToString();
                    employee.Country = dt.Rows[i]["Country"].ToString();
                    employee.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    employee.Date = dt.Rows[i]["Date"].ToString();
                    employee.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                    employees.Add(employee);
                }
                employeesBindingSource.DataSource = employees;
            }
        }

        DataTableCollection tableCollection;

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 WorkBook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration(){
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName); // add sheet to combobox
                        }
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-LGD01SI\SQLEXPRESS;Initial Catalog=dbDemo;Integrated Security=True";
                DapperPlusManager.Entity<Employee>().Table("Employees");
                List<Employee> employees = employeesBindingSource.DataSource as List<Employee>;
                if (employees != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(employees);
                    }
                }
                MessageBox.Show("Finished!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDemoDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dbDemoDataSet2.Employee);
            // TODO: This line of code loads data into the 'dbDemoDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dbDemoDataSet.Employees);

        }
    }
}
