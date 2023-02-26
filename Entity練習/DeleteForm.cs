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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Entity練習
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = context.ContactsTable.ToList();
            string ID = textBox1.Text;
           if(list.Select((x) => x.Id).Any((x) => x == textBox1.Text))
            {
                var data =
                from p in list
                where p.Id == ID
                select p;
                foreach (var item in data)
                {
                    context.ContactsTable.Remove(item);
                }
                context.SaveChanges();
                MessageBox.Show("刪除成功!");
                Clear();
            }
            else
            {
                MessageBox.Show("刪除失敗!");
            }
                
        }
        private void Clear()
        {
            textBox1.Clear();
        }
    }
   
}
