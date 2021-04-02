using CodeFirst_2.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductRepository productRepository = new ProductRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productRepository.GetProducts(); //Burada database de bulunan aktif productları form load olunca yani açıldığı zaman listelenmesini istedik.
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Create butonunun click eventine gerekli kodlamalarımızı yaptık.
            productRepository.CreateProduct(txtCreateProductName.Text, txtCreateDescription.Text, Decimal.Parse(txtCreateUnitPrice.Text));
            dataGridView1.DataSource = productRepository.GetProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update butonunun click eventine gerekli kodlamalarımızı yaptık.
            productRepository.UpdateProduct(id, txtUpdateProductName.Text, txtUpdateDescription.Text, Decimal.Parse(txtUpdateUnitPrice.Text));
            dataGridView1.DataSource = productRepository.GetProducts();

        }
        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Burada datagridview listemizde seçtimiz satırın bilgilerini update group box'umuzda yer alan textboxlara ilgili verilerin yazılmasını sağladık.
            id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            txtUpdateProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            txtUpdateDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
            txtCreateUnitPrice.Text = dataGridView1.CurrentRow.Cells["UnitPrice"].Value.ToString();
            
            txtDeleteProductID.Text = id.ToString(); // Burada delete butonunun üzerindeki Product ID textboxuna seçili olan sütundaki ürünün id'sini eklenmesini sağladık.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete butonunun click eventine gerekli kodlamaları yaptık.
            productRepository.DeleteProduct(id);
            dataGridView1.DataSource = productRepository.GetProducts();
            
        }
    }
}
