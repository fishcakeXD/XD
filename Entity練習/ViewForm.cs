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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var context = new ContactsModel();
            var list = context.ContactsTable.ToList();
            dataGridView1.DataSource = list;
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'contactDataSet.ContactsTable' 資料表。您可以視需要進行移動或移除。
            this.contactsTableTableAdapter.Fill(this.contactDataSet.ContactsTable);

        }
    }
   
       
        
}
