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
    public partial class ViewFrom : Form
    {
        public ViewFrom()
        {
           InitializeComponent();
           BindDate();
        }
        private void BindDate()
        {
            var context = new ContactsModel();
            var list = context.ContactsTable.ToList();
            dataGridView1.DataSource= list;
        }
    }
}
