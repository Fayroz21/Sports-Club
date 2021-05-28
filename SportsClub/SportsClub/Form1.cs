using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace SportsClub
{
    public partial class MembersForm : Form
    {
        

        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        string eventType;

        public MembersForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cost_Click(object sender, EventArgs e)
        {
            //fvmcfjnf
        }

        private void MembersForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
           
        }

        private void MembersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            
            if (radioButton_sport.Checked)
            {
                cmb_events.Items.Clear();
                eventType = "Sport";
            }
            else if (radioButton_trips.Checked)
            {
                cmb_events.Items.Clear();
                eventType = "Trip";
            }

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select eventname from events where eventtype = :type";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("type", eventType);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_events.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_events_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand selecEventData = new OracleCommand();
            selecEventData.Connection = conn;
            selecEventData.CommandText = "getEventData";
            selecEventData.CommandType = CommandType.StoredProcedure;

            selecEventData.Parameters.Add("evname", cmb_events.Text);
            selecEventData.Parameters.Add("sd", OracleDbType.Date, ParameterDirection.Output);
            selecEventData.Parameters.Add("ed", OracleDbType.Date, ParameterDirection.Output);
            selecEventData.Parameters.Add("evcost", OracleDbType.Int32, ParameterDirection.Output);

            selecEventData.ExecuteNonQuery();
            try
            {
                lbl_sd.Text = Convert.ToDateTime(selecEventData.Parameters["sd"].Value.ToString()).ToString();
                lbl_ed.Text = Convert.ToDateTime(selecEventData.Parameters["ed"].Value.ToString()).ToString();
                lbl_cost.Text = selecEventData.Parameters["evcost"].Value.ToString();
                
            }
            catch 
            {
                MessageBox.Show("Error");

            }
                
            



        }

        private void lbl_ed_Click(object sender, EventArgs e)
        {

        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            //Calculate total Cost
            int totalCost;
            totalCost = Convert.ToInt32(txt_notick.Text) * Convert.ToInt32(lbl_cost.Text);
            lbl_totalcost.Text = totalCost.ToString();

            //Get book id
            int newID;
            OracleCommand getBookId = new OracleCommand();
            getBookId.Connection = conn;
            getBookId.CommandText = "getbookid";
            getBookId.CommandType = CommandType.StoredProcedure;
            getBookId.Parameters.Add("bid", OracleDbType.Int32, ParameterDirection.Output);
            getBookId.ExecuteNonQuery();
            try
            {
                newID = Convert.ToInt32(getBookId.Parameters["bid"].Value.ToString()) + 1;

            }
            catch
            {
                newID = 1;

            }
                lbl_bookid.Text = newID.ToString();
            //Insert
            
            

            MessageBox.Show("Has Been Booked Successfully \nThe total Cost: " + totalCost);
        }
    }
}
