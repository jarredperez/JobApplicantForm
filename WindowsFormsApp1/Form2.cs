using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();
        public Form2(Form1 form1)
        {
            InitializeComponent();
            frm1 = form1;
        }

        public string ID { get; set; } //Property used to pass selected record back to form1

        /*public string FirstName { get; set; }

        public string LastName { get; set; }

        public string HomeTown { get; set; }

        public string Genders { get; set; }

        public string JobTitle { get; set; }

        public string DateOfBirth { get; set; }
        */

        public void buttonReturn_Click(object sender, EventArgs e)
        {
            //Create database connection
            SQLConnectionClass con = new SQLConnectionClass();
            con.OpenConnection();
            con.CreateCommand($"SELECT * FROM View_Applicants WHERE LastName LIKE '%{txtLastNameF2.Text}%'"); //Queries based on given last name

            SqlDataAdapter da = new SqlDataAdapter(con.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "View_Applicants");
            DataTable dt = ds.Tables["View_Applicants"];

            //Displays columns on listview
            listView1.Columns.Add("ID", 70);
            listView1.Columns.Add("FirstName", 70);
            listView1.Columns.Add("LastName", 70);
            listView1.Columns.Add("HomeTown", 70);
            listView1.Columns.Add("Gender", 70);
            listView1.Columns.Add("DesiredJobTitle", 100);
            listView1.Columns.Add("Date", 100);
            listView1.View = View.Details;

            //Displays row data based on last name search
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
            }


            con.CloseConnection();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //Clears listview
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtBoxIdReturn.Text = listView1.SelectedItems[0].SubItems[0].Text; //Stores ID of double-clicked record
            ID = txtBoxIdReturn.Text;
            this.Close();
        }
    }
}








/*string applicantid;
string applicantfirstname;
string applicantlastname;
string applicanthometown;
string applicantgender;
string applicantjobtitle;
string applicantdateofbirth;

for (int i = 0; i < dt.Rows.Count; i++)
{
    applicantid = dt.Rows[i]["ApplicantID"].ToString();
    applicantfirstname = dt.Rows[i]["FirstName"].ToString();
    applicantlastname = dt.Rows[i]["LastName"].ToString();
    applicanthometown = dt.Rows[i]["HomeTown"].ToString();
    applicantgender = dt.Rows[i]["Gender"].ToString();
    applicantjobtitle = dt.Rows[i]["DesiredJobTitle"].ToString();
    applicantdateofbirth = dt.Rows[i]["Date"].ToString();

    ID = applicantid;
    FirstName = applicantfirstname;
    LastName = applicantlastname;
    HomeTown = applicanthometown;
    Genders = applicantgender;
    JobTitle = applicantjobtitle;
    DateOfBirth = applicantdateofbirth;
}*/