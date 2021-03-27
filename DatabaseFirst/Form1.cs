using DatabaseFirst.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ApplicationDbContext db = new ApplicationDbContext();
        private void btnToList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.ToList();
            //ToList()  Bu method bir koşul olmaksızın tüm değerleri listelemek için kullanıyoruz. Verileri RAM'in Heap alanına çıkartıp oradan UI'a getirir.
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            //Where() Bu methodu veri tabanında bulunan veriler üzerinde filtreleme yapmak için kullanılır. 
            //Örneğin veri tabanında Stokta bulunan adetleri 30 ve üzeri olan ürünleri listeledik.
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock >= 30).ToList();
        }
    }
}
