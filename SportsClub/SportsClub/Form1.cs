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

        //Saved For efficiency
        string eventType;
        int eventID;
<<<<<<< HEAD
        int totalCost;
        int newID;

=======
>>>>>>> d95c183de2320cdde1b16677f06300f6ba182f85
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
<<<<<<< HEAD


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select distinct SportName from Sports ";
            cmd.CommandType = CommandType.Text;


            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Sport_cmb.Items.Add(dr[0]);
            }
            dr.Close();


=======
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select SportName from Sports ";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Sport_cmb.Items.Add(dr[0]);
            }
            dr.Close();

>>>>>>> d95c183de2320cdde1b16677f06300f6ba182f85
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
            cmd.CommandText = "select eventname from events where eventtype = :type and start_date > sysdate";
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
            selecEventData.Parameters.Add("sd", OracleDbType.TimeStamp, ParameterDirection.Output);
            selecEventData.Parameters.Add("ed", OracleDbType.TimeStamp, ParameterDirection.Output);
            selecEventData.Parameters.Add("evcost", OracleDbType.Int32, ParameterDirection.Output);
            selecEventData.Parameters.Add("eventID", OracleDbType.Int32, ParameterDirection.Output);

            selecEventData.ExecuteNonQuery();
            try
            {
                lbl_sd.Text = selecEventData.Parameters["sd"].Value.ToString().Substring(0,18) + " " + selecEventData.Parameters["sd"].Value.ToString().Substring(28);
                lbl_ed.Text = selecEventData.Parameters["ed"].Value.ToString().Substring(0, 18) + " " + selecEventData.Parameters["sd"].Value.ToString().Substring(28);
                lbl_cost.Text = selecEventData.Parameters["evcost"].Value.ToString();
                eventID = Convert.ToInt32(selecEventData.Parameters["eventID"].Value.ToString());
                
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
            //Insert
            OracleCommand insertBooking = new OracleCommand();
            insertBooking.Connection = conn;
            insertBooking.CommandText = "insert into bookings values(:bookID,:eventID,:memberID,:noOfPersons,:totalCost)";
            insertBooking.CommandType = CommandType.Text;
            insertBooking.Parameters.Add("bookID", newID);
            insertBooking.Parameters.Add("EventID", eventID);
            insertBooking.Parameters.Add("memberID", txt_memid.Text);
            insertBooking.Parameters.Add("noOfPersons", txt_notick.Text);
            insertBooking.Parameters.Add("totalCost", lbl_totalcost.Text);
            int r = insertBooking.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Has Been Booked Successfully \nThe total Cost: " + totalCost
                    + "\nBooking ID: " + newID);
            }

            else
            {
                MessageBox.Show("Error");
            }

           
        }

        private void Sport_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void MemberID_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_notick_Enter(object sender, EventArgs e)
        {
            
        }

        private void txt_notick_Leave(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate total Cost
            totalCost = Convert.ToInt32(txt_notick.Text) * Convert.ToInt32(lbl_cost.Text);
            lbl_totalcost.Text = totalCost.ToString();

            //Get book id
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
<<<<<<< HEAD

            lbl_bookid.Text = newID.ToString();

            btn_book.Visible = true;
=======
               lbl_bookid.Text = newID.ToString();

         
            //Insert
            OracleCommand insertBooking = new OracleCommand();
            insertBooking.Connection = conn;
            insertBooking.CommandText = "insert into bookings values(:bookID,:eventID,:memberID,:noOfPersons,:totalCost)";
            insertBooking.CommandType = CommandType.Text;
            insertBooking.Parameters.Add("bookID", newID);
            insertBooking.Parameters.Add("EventID", eventID);
            insertBooking.Parameters.Add("memberID", txt_memid.Text);
            insertBooking.Parameters.Add("noOfPersons", txt_notick.Text);
            insertBooking.Parameters.Add("totalCost", lbl_totalcost.Text);
            int r = insertBooking.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Has Been Booked Successfully \nThe total Cost: " + totalCost);
            }

            else
            {
                MessageBox.Show("Error");
            }

           
        }

        private void Sport_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void MemberID_txt_TextChanged_1(object sender, EventArgs e)
        {

>>>>>>> d95c183de2320cdde1b16677f06300f6ba182f85
        }
    }
}
