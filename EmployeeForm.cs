using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3343_PerkinsA_Lab01
{
    public partial class EmployeeForm : Form
    {
        // declare a List to store Employee objects

        List<Employee> employeeList = new List<Employee>();


        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the text box controls and set focus

            nameTextBox.Clear();
            idTextBox.Clear();
            departmentTextBox.Clear();
            positionTextBox.Clear();

            // clear the list box
            employeeListBox.Items.Clear();

            // set focus
            nameTextBox.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            string name;
            int id;
            string department;
            string position;

            if (nameTextBox.Text != "")
            {
                // assign value to the name

                name = nameTextBox.Text;

                if (departmentTextBox.Text != "")
                {
                    // assign value to deparment

                    department = departmentTextBox.Text;

                    if (positionTextBox.Text != "")
                    {
                        // assign value to position

                        position = positionTextBox.Text;

                        if (int.TryParse(idTextBox.Text, out id))

                        {
                            if (id > 0)
                            {

                                // create Employee object

                                Employee myEmployee = new Employee();

                                // assign vaules using Properties

                                myEmployee.Name = name;
                                myEmployee.ID = id;
                                myEmployee.Department = department;
                                myEmployee.Position = position;

                                // add Employee object to the List 


                                employeeList.Add(myEmployee);

                                // add name field of the myEmployee object to list box

                                employeeListBox.Items.Add(myEmployee.Name);


                                //clear text box controls and set focus

                                nameTextBox.Clear();
                                idTextBox.Clear();
                                departmentTextBox.Clear();
                                positionTextBox.Clear();
                                nameTextBox.Focus();

                            }
                            else
                            {
                                MessageBox.Show("ID Number must be greater than zero.");
                                idTextBox.Text = "";
                                idTextBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID Number must be a whole number.");
                            idTextBox.Text = "";
                            idTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Position cannot be blank.");
                        positionTextBox.Text = "";
                        positionTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Department cannot be blank.");
                    departmentTextBox.Text = "";
                    departmentTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("Name cannot be blank.");
                nameTextBox.Text = "";
                nameTextBox.Focus();
            }

        }

        private void employeeListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int index = employeeListBox.SelectedIndex;

            // create an instance of the Employee DetailsForm passing the employeeList object as an argument


            EmployeeDetailsForm detailsForm = new EmployeeDetailsForm(employeeList[index]);


            // show details form

            detailsForm.Show();
        }
    }
}

            
            



 