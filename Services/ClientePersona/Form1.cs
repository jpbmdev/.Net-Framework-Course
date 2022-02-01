using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientePersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSearch.Text);
            using (WSPersons.WSPersonsClient client = new WSPersons.WSPersonsClient())
            {
                var person = client.GetPersonById(id);
                string data = person.FirstName + " " + person.LastName;

                if (person.FirstName == null && person.LastName == null)
                {
                    data = person.Error;
                }
                txtResult.Text = data;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
