namespace List_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> persons = new List<string>();
            persons.Add("Ali");
            persons.Add("Ayþe");
            persons.Add("Fatma");
            persons.Add("Veli");
            persons.Add("Mehmet");

            foreach (string item in persons)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<int> numbers = new List<int>();
            numbers.Add(15);
            numbers.Add(32);
            numbers.Add(27);
            numbers.Add(86);
            numbers.Add(48);
            numbers.Add(12);

            foreach (int item in numbers)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}