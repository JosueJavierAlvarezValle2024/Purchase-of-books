namespace Purchase_of_books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book(Convert.ToString(txttitle.Text), Convert.ToString(txtauthor.Text), Convert.ToDouble(txtcopies.Text), Convert.ToDouble(txtcost.Text));
          
            lbltitle.Text = "Title : " + txttitle.Text;
            lblauthor.Text = "The author is : " + txtauthor.Text;
            lblcopies.Text = "The number of copies is : " + txtcopies.Text;
            lblcost.Text = "The cost is : " + txtcost.Text;

            lbltotalcost.Text = "The cost total is: " + Convert.ToString(book.buy());
        }

    }
}
