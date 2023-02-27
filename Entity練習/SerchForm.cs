using Entity練習.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity練習
{
    public partial class SerchForm : Form
    {
        public SerchForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var contect = new ContactsModel();
            var dataId = textBox1.Text;
            var list  = contect.ContactsTable.ToList();
            if (list.Any((x) => x.Id == dataId))
            {
                var list_data = contect.ContactsTable.Where(x => x.Id == dataId).ToList();
                dataGridView1.DataSource = list_data;
            }
            else
            {
                MessageBox.Show("查無此項");
            }

        }
    }
}
