using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace BohdanDZ4_1
{
    public partial class Form1 : Form
    {
            public Form1()
            {
                InitializeComponent();
            }



            List<Book> books = new List<Book>();
            List<Products> products = new List<Products>();
            List<Item> items = new List<Item>();
        //DataTable ItemTable = new DataTable();
        //DataTable GroceryTable = new DataTable();
        //DataTable BookTable = new DataTable();

         int Count = 0;
         
         private void Form1_Load(object sender, EventArgs e)
         {
            
            items.Add(new Item((Count + 1),1000000,"������ ������i�","�������","02.10.22","����� ����� �����")); 
            dataGridView1.Columns.Add("Column1", "�����");
            dataGridView1.Columns.Add("Column2", "����� ����������");
            dataGridView1.Columns.Add("Column3", "ֳ���");
            dataGridView1.Columns.Add("Column4", "���� ���������");
            dataGridView1.Columns.Add("Column5", "����");
            dataGridView1.Rows.Add(items[Count].Name, items[Count].Origin, items[Count].Price, items[Count].Date, items[Count].Description);
            dataGridView1.Rows[Count].HeaderCell.Value = "�������";
            Count++;
        }

   
        private void AddBook_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("�� ������ ��������� ����� ����. ��������� �� ���!");
                return;
            }

            string name = textBox1.Text;
            int pages = 0;
            try
            {
                pages = Int32.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("������� ������ ������ �����, � �� �����");
                return;
            }
            if (pages < 1)
            {
                MessageBox.Show("����� ������ ���� ���������");
                return;
            }
            string publisher = textBox4.Text;
            List<string> authors = new List<string> {textBox3.Text};
            int price = 0;
            try
            {
                price = Int32.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("ֳ��� ������a ������ �����, � �� �����");
                return;
            }
            if (price < 1)
            {
                MessageBox.Show("ֳ��� ������a ���� ������a");
                return;
            }
            string origin = textBox5.Text;
            string date = textBox8.Text;
            string description = textBox7.Text;
            Book book = new Book(Count,name,pages,publisher,authors,price,origin,date,description);
            dataGridView1.Rows.Add(book.Name, book.Origin, book.Price, book.Date, book.Description);
            dataGridView1.Rows[Count].HeaderCell.Value = "�����";
            Count++;
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "")
            {
                MessageBox.Show("�� ������ ��������� ����� ����. ��������� �� ���!");
                return;
            }
            string name = textBox16.Text;
            string unit = textBox15.Text;
            int quantity = 0;
            try
            {
                quantity = Int32.Parse(textBox14.Text);
            }
            catch
            {
                MessageBox.Show("ʳ������ ������� ������ �����, � �� �����");
                return;
            }
            if (quantity < 1)
            {
                MessageBox.Show("ʳ������ ������� ���� ���������");
                return;
            }
            int price = 0;
            try
            {
                price = Int32.Parse(textBox13.Text);
            }
            catch
            {
                MessageBox.Show("ֳ��� ������a ������ �����, � �� �����");
                return;
            }
            if (price < 1)
            {
                MessageBox.Show("ֳ��� ������a ���� ������a");
                return;
            }
            string origin = textBox12.Text;
            string date = textBox11.Text;
            string valid = textBox10.Text;
            string description = textBox9.Text;

            Products products = new Products(Count,name,price,origin,quantity,unit,date,valid,description);
            dataGridView1.Rows.Add(products.Name, products.Origin, products.Price, products.Date, products.Description);
            dataGridView1.Rows[Count].HeaderCell.Value = "�������";
            Count++;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(Count <= 0)
            {
                MessageBox.Show("����� ������");
                return;
            }
            dataGridView1.Rows.RemoveAt(Count - 1);
            Count--;
        }


    }
 }
