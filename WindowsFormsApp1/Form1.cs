using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckIfEmpty(string value, TextBox box) //Checks if a given textbox is empty after submitting the form 
        {
            bool status = true;
            if (value == "")
            {
                errorProvider1.SetError(box, "Please, enter a value in order to submit job application");
                status = false;
            }
            else
            {
                errorProvider1.SetError(box, "");
            }
            return status;
        }

        private bool CheckIfComboEmpty(string value, ComboBox box) //Checks if a given combobox is not selected after submitting the form 
        {
            bool status = true;
            if (value == "")
            {
                errorProvider1.SetError(box, "Please, enter a value in order to submit job application");
                status = false;
            }
            else
            {
                errorProvider1.SetError(box, "");
            }
            return status; 
        }

        private void buttonSave_Click(object sender, EventArgs e) //Code for save button
        {
            //Create connection to database
            SQLConnectionClass saveButton = new SQLConnectionClass();
            saveButton.OpenConnection();
            saveButton.CreateCommand("");
            
            //Check if the radio buttons for the applicant's gender are checked, and which of them is checked
            string g = string.Empty;
            if (radioButtonFemale.Checked == false && radioButtonMale.Checked == false)
            {
                errorProvider3.SetError(radioButtonMale, "Please, select your gender");
            }
            if (radioButtonMale.Checked == true) 
            {
                g = "Male";
            }
            if (radioButtonFemale.Checked == true)
            {
                g = "Female";
            }

            //Check if textboxes and comboboxes are not empty before submitting application
            string n = txtFirstname.Text;
            string l = txtLastname.Text;
            string j = txtJobtitle.Text;
            bool firstName = CheckIfEmpty(n, txtFirstname);
            bool lastName = CheckIfEmpty(l, txtLastname);
            bool jobTitle = CheckIfComboEmpty(j, txtJobtitle);

            if (firstName && lastName && jobTitle)
                {
                    saveButton.cmd.CommandText = "AddApplicant"; //Stored Procedure for inserting values into database table
                    saveButton.cmd.CommandType = CommandType.StoredProcedure;
                    saveButton.cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = txtFirstname.Text;
                    saveButton.cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = txtLastname.Text;
                    saveButton.cmd.Parameters.Add("@checkBoxCity", SqlDbType.Bit).Value = checkBoxCity.Checked;
                    saveButton.cmd.Parameters.Add("@g", SqlDbType.VarChar, 50).Value = g;
                    saveButton.cmd.Parameters.Add("@JobTitle", SqlDbType.VarChar, 50).Value = txtJobtitle.Text;
                    saveButton.cmd.Parameters.Add("@dateTime", SqlDbType.Date).Value = dateTimePicker1.Text;
                    saveButton.cmd.ExecuteNonQuery();
                }
                saveButton.CloseConnection();
        }

        private void buttonSearch_Click(object sender, EventArgs e) //Code for search button
        {
            Form2 form2 = new Form2(this); //instance of second form
            form2.ShowDialog();

            //Create connection to database
            SQLConnectionClass saveButton = new SQLConnectionClass();
            saveButton.OpenConnection();
            saveButton.CreateCommand($"SELECT * FROM View_Applicants WHERE ApplicantID = '{form2.ID}'"); //Receives ID from the record selected on form 2
            SqlDataAdapter da = new SqlDataAdapter(saveButton.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "View_Applicants");
            DataTable dt = ds.Tables["View_Applicants"];

            //Assigns each column value on dt(table) to the labels shown on the form to display applicant data
            labelID.Text = dt.Rows[0]["ApplicantID"].ToString();
            labelFirstName.Text = dt.Rows[0]["FirstName"].ToString();
            labelLastName.Text = dt.Rows[0]["LastName"].ToString();
            labelHomeTown.Text = dt.Rows[0]["HomeTown"].ToString();
            labelGender.Text = dt.Rows[0]["Gender"].ToString();
            labelJobTitle.Text = dt.Rows[0]["DesiredJobTitle"].ToString();
            labelDate.Text = dt.Rows[0]["Date"].ToString();

            saveButton.CloseConnection();

        }

        private void ButtonStrengths_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this); 
            form3.ShowDialog();


        }



























        /*private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JARRED_XPS15\\SQLEXPRESS;Initial Catalog=EFDB;Integrated Security=True");
            con.Open();

            //string queryString = $"SELECT * FROM View_Applicants WHERE LastName LIKE '%{txtLastNameSearch}%'";
            SqlCommand qry_cmd = new SqlCommand($"SELECT * FROM View_Applicants WHERE LastName LIKE '%{txtLastNameSearch.Text}%'", con);
            //SqlDataReader dataReader = qry_cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(qry_cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "View_Applicants");
            DataTable dt = ds.Tables["View_Applicants"];

            listView1.Columns.Add("ID", 70);
            listView1.Columns.Add("FirstName", 70);
            listView1.Columns.Add("LastName", 70);
            listView1.Columns.Add("HomeTown", 70);
            listView1.Columns.Add("Gender", 70);
            listView1.Columns.Add("DesiredJobTitle", 100); 
            listView1.Columns.Add("Date", 100);
            listView1.View = View.Details;


            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[i].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString()); 
            }

            con.Close();
        }*/
    }
}
