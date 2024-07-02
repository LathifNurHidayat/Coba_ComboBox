namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Pilih jenis kendaraan";
            comboBox1.Items.Add("Motor");
            comboBox1.Items.Add("Mobil");
            comboBox1.Items.Add("truck");
            comboBox1.Items.Add("Sepeda");
            comboBox1.Items.Add("Sepeda listrik");
            comboBox1.Items.Add("Motor Listrik");

            comboBox2.DataSource = Enum.GetValues(typeof(Role));

        }


        public enum Role
        {
            Fighter, Marksman, Tank, Mage, Support, Assanin
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var ListMerek = new List<NamaMerek>
            {
                new NamaMerek("Toyota","Mobil"),
                new NamaMerek("Isuzu","Mobil"),
                new NamaMerek("Mitsubishi","Mobil"),
                new NamaMerek("Mitsubishi","Truk"),
                new NamaMerek("ISUZU","Truk"),
                new NamaMerek("Umplung","Truk"),
            };

            treeView1.Nodes.Add("Mobil", "Mobil");
            treeView1.Nodes.Add("Truk", "Truk");

            foreach (var item in ListMerek)
                treeView1.Nodes[item.jeniskendaraan].Nodes.Add(item.MerekName);
        }
        private class NamaMerek
        {
            public NamaMerek(string merek, string jenis)
            {
                MerekName = merek;
                jeniskendaraan = jenis;
            }
            public string MerekName { get; set; }
            public string jeniskendaraan { get; set; }
        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (MessageBox.Show("Anda yakin ingin menghapus item ?", "Hapus Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                    MessageBox.Show("Item berhasil dihapus");
                }
                else
                {
                    MessageBox.Show("Item tidak dihapus");
                }
            }
            else
            {
                MessageBox.Show("Mohon pilih item terlebih dahulu");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin menghapus semua item ?", "Hapus Semua", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                comboBox1.Items.Clear();
                MessageBox.Show("Semua item anda sudah terhapus");
            }
            else
            {
                MessageBox.Show("Iten tidak dihapus");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(comboBox2.SelectedItem.ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anda yakin akan lanjut ke form 2 ?");
            if {

            }
        }
    }
}