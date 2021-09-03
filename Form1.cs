using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator_Version_2
{
    public partial class Form1 : Form
    {
        double h;
        double w;
        double t;

        private static string myConString = ConfigurationManager.ConnectionStrings["rain"].ConnectionString;
        SqlConnection con = new SqlConnection(myConString);

        public Form1()
        {
            InitializeComponent();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            h = Double.Parse(heightTextBox.Text);
            w = Double.Parse(weightTextBox.Text);

            t = w / (h * h);

            if (t <= 18.5)
            {
                statusTextBox.Text = "Underweight";
            }
            else if (t <= 24.9)
            {
                statusTextBox.Text = "Normal";
            }
            else if (t <= 29.9)
            {
                statusTextBox.Text = "Overweight";
            }
            else if (t > 29.9)
            {
                statusTextBox.Text = "Obese";
            }

            Database();
        }

        private void Database()
        {
            //Open connection to database
            con.Open();



            //Add string with SQL query
            string InsertQuery = "Insert Into BMICal Values (@patientID, @weight, @height, @status)";

            SqlCommand sqlCommand = new SqlCommand(InsertQuery, con);
            sqlCommand.Parameters.AddWithValue("@patientID", patientIDTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@weight", weightTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@height", heightTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@status", statusTextBox.Text);


            //Executes SQL query
            sqlCommand.ExecuteNonQuery();
            //Message box, informs that the record is created.
            MessageBox.Show("Successfully created a record!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        private void iDTextBox_Validate(object sender, CancelEventArgs e)
        {
            if (patientIDTextBox.Text.Length > 13 || patientIDTextBox.Text.Length < 13)
            {
                e.Cancel = true;
                patientIDTextBox.Focus();
                errorProvider1.SetError(patientIDTextBox, "Patient ID must be 13 digits.");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            patientIDTextBox.Clear();
            weightTextBox.Clear();
            heightTextBox.Clear();
            statusTextBox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void patientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            bool temp = false;

            SqlCommand cmd = new SqlCommand("select * from BMICal where patientID='" + patientIDTextBox.Text.Trim() + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                weightTextBox.Text = dr.GetString(1);
                heightTextBox.Text = dr.GetString(2);
                statusTextBox.Text = dr.GetString(3);
                temp = true;
            }
            if (temp == false)
            MessageBox.Show("Gone");
            con.Close();
        }
    }
    
}
