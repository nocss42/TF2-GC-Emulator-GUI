using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Drawing.Text;
using System.ComponentModel;
using System.Security.Cryptography;
namespace TF2_GC_GUI
{
    public partial class Form1 : Form
    {
        public static string invlocation;
        public static List<Tf2Item> items;
        private BindingList<Tf2Item> sortedStuff;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // mm yess stackoverflow
            // If you're building from source make sure you put the TF2ITEMS.txt next to your built exe
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"TF2Items.txt");
            items = ItemList.LoadItems(path);
            listBox2.DataSource = items;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog inv = new OpenFileDialog();
            inv.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (inv.ShowDialog() == DialogResult.OK && inv.FileName.Contains("inventory"))
            {
                invlocation = inv.FileName;
                var invLin = File.ReadAllLines(inv.FileName);
                var inventoryItems = new List<Tf2Item>();
                foreach (var line in invLin)
                {
                    var trimtram = line.Trim();
                    if (trimtram.StartsWith("\"" + "def_index" + "\""))
                    {
                        int lastind = trimtram.LastIndexOf("\"");
                        string value = trimtram.Substring(14, lastind - 14);
                        var filtered = items
                            //lmao reusing code from the list loader
                            .Where(item => item.Defindex.ToString() == value)
                            .ToList();
                        inventoryItems.AddRange(filtered);
                    }
                }
                sortedStuff = new BindingList<Tf2Item>(inventoryItems.OrderBy(item => item.Defindex).ToList());
                listBox1.DataSource = sortedStuff;
                if (invLin.Length > 0)
                {
                    invLin = invLin.Take(invLin.Length - 1).ToArray();
                }
                // it kept adding a whitespace which messed with things hahaha
                File.WriteAllText(invlocation, string.Join(Environment.NewLine, invLin));

            }
            else
            {
                MessageBox.Show("Invalid File.");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (invlocation != null)
            {
                File.AppendAllText(invlocation, Environment.NewLine + "}");
                MessageBox.Show("Saved!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("select your text file lmao");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (invlocation != null)
            {
                var selectedItem = listBox2.SelectedItem as Tf2Item;
                int defindex = selectedItem.Defindex;
                ItemList.AddNewInventoryEntry(invlocation, defindex);
                sortedStuff.Add(selectedItem);
            }
            else
            {
                MessageBox.Show("add your inv in you fatso");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string query = textBox1.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(query))
            {
                listBox2.DataSource = items;
            }
            else
            {
                var filtered = items
                    .Where(item => item.Name.ToLower().Contains(query) ||
                                   item.Defindex.ToString().Contains(query))
                    .ToList();

                listBox2.DataSource = filtered;
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (invlocation != null)
            {
                // yummy stackoverflow code stolen
                Random rnd = new Random();
                // Yes, theres so many medals, makes the funny random button NOT fun :(
                // THERES SO MANY GOD DAMN
                string[] bannedItems = ["medal", "UGC", "ETF2L", "Brazil Fortress", "AsiaFortress","LBTF2","TF2Connexion","Chapelaria","ozfortress","OWL 1","CappingTV","FreshMeat","Arms Race 1","Arms Race 2","Arms Race 3","PURE League","Ready Steady", "TFCL","FBTF","ESL","Map Stamp", "Map Token", "RGL.gg", "ESEA 6s", "South American","RGLgg","League", "HighLander","RETF2","NHBL"];
                var iHateMedalsSOMUCH = items
                    .Where(i => !bannedItems.Any(b =>
                        i.Name.Contains(b, StringComparison.OrdinalIgnoreCase)))
                    .ToList();
                // Fixed my horrible effigy of a table
                if (iHateMedalsSOMUCH.Count > 0)
                    // used to just be a random defindex value, keeping the check so something doesn't break
                {
                    var randomItem = iHateMedalsSOMUCH[rnd.Next(iHateMedalsSOMUCH.Count)];
                    sortedStuff.Add(randomItem);
                    ItemList.AddNewInventoryEntry(invlocation, randomItem.Defindex);
                }
            }
            else
            {
                MessageBox.Show("add your inventory.txt!!!");
            }
        }
    }
}

