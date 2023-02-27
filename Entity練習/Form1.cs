using Entity練習.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new DeleteForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new ViewFrom();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ReviseForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new SerchForm();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var context = new ContactsModel();
            var list = ProductCSV("product.csv");
            foreach(var item in list)
            {
                context.ContactsTable.Add(item);
            }
            try
            {
                context.SaveChanges();
                MessageBox.Show("匯入成功!");
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }
           
            dataGridView1.DataSource = list;
        }
        private static List<ContactsTable> ProductCSV(string path)
        {
            return File.ReadAllLines(path)
                .Skip(1)
                .Where(row => row.Length > 0)
                .Select(ContactsTable.ParseRow)
                .ToList();
            
        }
        

    }
}
