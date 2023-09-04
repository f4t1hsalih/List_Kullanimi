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

            foreach (var item in persons)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}