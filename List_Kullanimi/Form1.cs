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
            persons.Add("Ay�e");
            persons.Add("Fatma");
            persons.Add("Veli");
            persons.Add("Mehmet");

            persons.Remove("Veli");

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

            if (numbers.Contains(32))
            {
                MessageBox.Show("Bu say� var");
            }
            else
            {
                MessageBox.Show("Bu say� yok");
            }
        }

        private void btnListele3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            List<Persons> person = new List<Persons>();
            person.Add(new Persons
            {
                Name = "Ali",
                Last_name = "Demir",
                Job = "��retmen"
            });

            foreach (Persons item in person)
            {
                listBox3.Items.Add(item.Name + " " + item.Last_name + " " + item.Job);
            }
        }
    }
}