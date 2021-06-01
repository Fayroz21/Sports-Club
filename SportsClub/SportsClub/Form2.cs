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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a value");
                return;
            }
            String command1 = "select * from events where eventtype =: type";
            adapter = new OracleDataAdapter(command1, ordb);
            adapter.SelectCommand.Parameters.Add("type", comboBox1.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            builder = new OracleCommandBuilder(adapter);
            try
            {
                adapter.Update(ds.Tables[0]);

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
<<<<<<< HEAD



        private void Form2_Load(object sender, EventArgs e)
        {

        }

=======
>>>>>>> d95c183de2320cdde1b16677f06300f6ba182f85
    }
}
