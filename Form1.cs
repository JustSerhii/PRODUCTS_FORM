using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {

        DataTable table1 = new DataTable();
        List<Good> list = new List<Good>();
        public List<Good> Goods { get; set; }
        public Form1()
        {
            Goods = GetGoods();
            InitializeComponent();
        }

        private List<Good> GetGoods()
        {
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Price", typeof(int));
            table1.Columns.Add("Country", typeof(string));
            table1.Columns.Add("Packing date", typeof(string));
            table1.Columns.Add("Description", typeof(string));

            Books book1 = new Books("The Fellowship of the Ring", 20, "England", "21.09.2022", "Book", 423, "George Allen & Unwin", "John Ronald Reuel Tolkien");
            list.Add(book1);

            Products product1 = new Products("Skittles", 5, "USA", "04.10.2022", "Sweets", "04.11.2022", 20, "kg");
            list.Add(product1);
            

            dataGridView1.DataSource = table1;


            for (int i = 0; i < Goods.Count; i++)
            {
                table1.Rows.Add(Goods[i].Name, Goods[i].Price, Goods[i].Country, Goods[i].Date, Goods[i].Description);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

        }
    }
}
