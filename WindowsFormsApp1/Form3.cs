using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        Form1 frm1 = new Form1();
        public Form3(Form1 form1)
        {
            InitializeComponent();
            frm1 = form1;
        }

        public string ID { get; set; }

        private void ButtonSearchLastName_Click(object sender, EventArgs e)
        {
            //Create database connection
            SQLConnectionClass con = new SQLConnectionClass();
            con.OpenConnection();
            con.CreateCommand($"SELECT * FROM View_Applicants WHERE LastName LIKE '%{txtLastNameF3.Text}%'"); //Queries based on given last name

            SqlDataAdapter da = new SqlDataAdapter(con.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "View_Applicants");
            DataTable dt = ds.Tables["View_Applicants"];

            //Displays columns on listview
            listViewApplicant.Columns.Add("ApplicantID", 70);
            listViewApplicant.Columns.Add("FirstName", 70);
            listViewApplicant.Columns.Add("LastName", 70);
            listViewApplicant.Columns.Add("HomeTown", 70);
            listViewApplicant.Columns.Add("Gender", 70);
            listViewApplicant.Columns.Add("DesiredJobTitle", 100);
            listViewApplicant.Columns.Add("Date", 100);
            listViewApplicant.View = View.Details;

            //Displays row data based on last name search
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewApplicant.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewApplicant.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewApplicant.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewApplicant.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewApplicant.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listViewApplicant.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listViewApplicant.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
            }

            con.CloseConnection();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            listViewApplicant.Items.Clear();
        }

        private void listViewApplicant_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = listViewApplicant.SelectedItems[0].SubItems[0].Text;
            ID = id;
            SQLConnectionClass con = new SQLConnectionClass();
            con.OpenConnection();
            con.CreateCommand($"SELECT * FROM[EFDB].[dbo].[Job_Applicants] INNER JOIN[EFDB].[dbo].[Applicants_Strengths] on(Job_Applicants.ApplicantID = Applicants_Strengths.ApplicantID) WHERE Job_Applicants.ApplicantID = {ID}");
            SqlDataAdapter da = new SqlDataAdapter(con.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Applicants_Strengths");
            DataTable dt = ds.Tables["Applicants_Strengths"];
            listViewStrengths.Columns.Add("ApplicantID", 70);
            listViewStrengths.Columns.Add("FirstName", 70);
            listViewStrengths.Columns.Add("LastName", 70);
            listViewStrengths.Columns.Add("HomeTown", 70);
            listViewStrengths.Columns.Add("Gender", 70);
            listViewStrengths.Columns.Add("DesiredJobTitle", 100);
            listViewStrengths.Columns.Add("Date", 100);
            listViewStrengths.Columns.Add("ID", 70);
            listViewStrengths.Columns.Add("ApplicantID", 70);
            listViewStrengths.Columns.Add("Strength", 300);
            listViewStrengths.View = View.Details;
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewStrengths.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
            }
        }
        private void ButtonAddStrength_Click(object sender, EventArgs e)
        {
            SQLConnectionClass con = new SQLConnectionClass();
            con.OpenConnection();
            con.CreateCommand("");
            con.cmd.CommandText = "AddStrength";
            con.cmd.CommandType = CommandType.StoredProcedure;
            con.cmd.Parameters.Add("@ApplicantID", SqlDbType.Int).Value = ID;
            con.cmd.Parameters.Add("@Strength", SqlDbType.VarChar, 50).Value = txtStrength.Text;
            con.cmd.ExecuteNonQuery();
            con.CreateCommand($"SELECT * FROM[EFDB].[dbo].[Job_Applicants] INNER JOIN[EFDB].[dbo].[Applicants_Strengths] on(Job_Applicants.ApplicantID = Applicants_Strengths.ApplicantID) WHERE Job_Applicants.ApplicantID = {ID}");
            SqlDataAdapter da = new SqlDataAdapter(con.cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Applicants_Strengths");
            DataTable dt = ds.Tables["Applicants_Strengths"];
            listViewStrengths.Columns.Add("ApplicantID", 70);
            listViewStrengths.Columns.Add("FirstName", 70);
            listViewStrengths.Columns.Add("LastName", 70);
            listViewStrengths.Columns.Add("HomeTown", 70);
            listViewStrengths.Columns.Add("Gender", 70);
            listViewStrengths.Columns.Add("DesiredJobTitle", 100);
            listViewStrengths.Columns.Add("Date", 100);
            listViewStrengths.Columns.Add("ID", 70);
            listViewStrengths.Columns.Add("ApplicantID", 70);
            listViewStrengths.Columns.Add("Strength", 300);
            listViewStrengths.View = View.Details;
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                listViewStrengths.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[7].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                listViewStrengths.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
            }
        } 

        private void ButtonDeleteStrength_Click(object sender, EventArgs e)
        {
            string idremove = listViewStrengths.SelectedItems[0].SubItems[7].Text;
            SQLConnectionClass con = new SQLConnectionClass();
            con.OpenConnection();
            con.CreateCommand($"DELETE FROM Applicants_Strengths WHERE ID = {idremove}");
            con.cmd.ExecuteNonQuery();
            listViewStrengths.Items.RemoveAt(listViewStrengths.SelectedIndices[0]);
        }

        private void ButtonClear2_Click(object sender, EventArgs e)
        {
            listViewStrengths.Items.Clear();
        }
    }
}
