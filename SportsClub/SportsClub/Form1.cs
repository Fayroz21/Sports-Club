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
    }
}
