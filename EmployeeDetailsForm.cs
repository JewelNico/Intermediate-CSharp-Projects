using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3343_PerkinsA_Lab01
{
    public partial class EmployeeDetailsForm : Form
    {
     

        public EmployeeDetailsForm(Employee referenceToEmployeeList)
        {
            InitializeComponent();

            //populate detail with the information from the Employee Object

            nameLabel.Text = referenceToEmployeeList.Name;
            idLabel.Text = referenceToEmployeeList.ID.ToString();
            departmentLabel.Text = referenceToEmployeeList.Department;
            positionLabel.Text = referenceToEmployeeList.Position;
        


        }

        private void clearDetailButton_Click(object sender, EventArgs e)
        {
            // close multi form

            this.Close();
        }
    }
}
