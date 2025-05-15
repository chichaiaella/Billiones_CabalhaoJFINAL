using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Billiones_CabalhaoJFINAL
{
    public partial class Grades: UserControl
    {
        DataTable dt = new DataTable();
        public Grades()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grades_Load(object sender, EventArgs e)
        {
            // table header
            dt.Columns.Add("First Name", Type.GetType("System.String"));
            dt.Columns.Add("Last Name", Type.GetType("System.String"));
            dt.Columns.Add("Middle Name", Type.GetType("System.String"));
            dt.Columns.Add("Program", Type.GetType("System.String"));
            dt.Columns.Add("Subjects", Type.GetType("System.String"));
            dt.Columns.Add("Prelim 20%", Type.GetType("System.Single"));
            dt.Columns.Add("Midterm 30%", Type.GetType("System.Single"));
            dt.Columns.Add("Final 50%", Type.GetType("System.Single"));
            dt.Columns.Add("Average");
            dt.Columns.Add("Remarks");

            dgvGradesInfo.DataSource = dt;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if user input null it return a message box
            if (txtFirstname.Text == "" ||
                txtLastname.Text == "" ||
                txtMiddlename.Text == "" ||
                txtProgram.Text == "" ||
                txtPrelim.Text == "" ||
                txtMidterm.Text == "" ||
                txtFinal.Text == ""
                ) { 
                MessageBox.Show("Please fill in all fields.");
            }
            //if user input all of text box 
            else
            {
                //grades prelim midterm and final
                float prelim = Convert.ToSingle(txtPrelim.Text);
                float midterm = Convert.ToSingle(txtMidterm.Text);
                float final = Convert.ToSingle(txtFinal.Text);
                //average
                var average = (prelim + midterm + final) / 3;
                var FinalAverage =average.ToString("F2");
                

                //remarks of grades
                string remarks = "";
                if (average == 1)
                {
                    remarks = "Outstanding";
                }
                else if (average <= 1.50)
                {
                    remarks = "Very Good";
                }
                else if (average <= 2.25)
                {
                    remarks = "Good";
                }
                else if (average <= 2.75)
                {
                    remarks = "Fair";
                }
                else if (average == 3)
                {
                    remarks = "Passed";
                }
                else
                {
                    remarks = "Failure";
                }


                // display in data grid view
                dt.Rows.Add(txtFirstname.Text,
                            txtLastname.Text,
                            txtMiddlename.Text,
                            txtProgram.Text,
                            cmbSubjects.SelectedItem,
                            txtPrelim.Text,
                            txtMidterm.Text,
                            txtFinal.Text,
                            FinalAverage,
                            remarks);




                int lastRowIndex = dgvGradesInfo.Rows.Count - 1;
                DataGridViewRow newdata = dgvGradesInfo.Rows[lastRowIndex];

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear all input/textbox
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtMiddlename.Text = "";
            txtProgram.Text = "";
            cmbSubjects.Text = "";
            txtPrelim.Text = "";
            txtMidterm.Text = "";
            txtFinal.Text = "";
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            //clear all the data in datagridview
            ((DataTable)dgvGradesInfo.DataSource).Clear();
        }
    }
}
