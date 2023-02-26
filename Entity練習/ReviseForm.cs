using Entity練習.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity練習
{
    public partial class ReviseForm : Form
    {
        public ReviseForm()
        {
            InitializeComponent();
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            var context = new ContactsModel();
            var data_Id = textBox1.Text;
            var list = context.ContactsTable.ToList();
            if (list.Select((x) => x.Id).Any((x) => x == textBox1.Text))
            {
                var list_data = context.ContactsTable.Where((x) => x.Id == data_Id).ToList();
                foreach (var item in list_data)
                {
                    item.Name = textBox2.Text;
                    item.Total = textBox3.Text;
                    item.Price = textBox4.Text;
                    item.Type = textBox5.Text;
                }
                context.SaveChanges();
                MessageBox.Show("修改成功!");
            }
            else
            {
                MessageBox.Show("修改失敗!");
            }
        }
    }
}
