using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication2
{
 
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee employee = new PartTimeEmployee
            {
                FirstName = txtFname.Text,
                LastName = txtLname.Text,
                RatePerHour = double.Parse(txtboxratehour.Text),
                TotalHoursWorked = int.Parse(txtboxhourswork.Text)
            };

            
            double salary = employee.ComputeSalary();

            
            label10Fname.Text = employee.GetEmployeeDetails();
          }
        
    }
}
