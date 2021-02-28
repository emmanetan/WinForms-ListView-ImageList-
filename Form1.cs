using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace _6._7.ListView_et_ImageList
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListView(0);
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadListView(0);
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadListView(2);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadListView(3);
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadListView(1);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void LoadListView(int nbr)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            // listView1.View = View.Details; // or just do =1
            switch (nbr)
            {
                case 0: listView1.View =View.LargeIcon;
                    break;
                case 1: listView1.View =View.Details;
                    break;
                case 2:
                    listView1.View = View.SmallIcon;
                    break;
                case 3:
                    listView1.View = View.List;
                    break;

            }
        
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            // listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.

            ListViewItem item1 = new ListViewItem("koko", 0);
            item1.SubItems.Add("Anime");
            item1.SubItems.Add("Inconnu");
            ListViewItem item2 = new ListViewItem("didi", 1);
            item2.SubItems.Add("Anime");
            item2.SubItems.Add("Inconnu");
            ListViewItem item3 = new ListViewItem("kiki", 0);
            item3.SubItems.Add("Anime");
            item3.SubItems.Add("Inconnu");

            // Create columns for the items and subitems.
            listView1.Columns.Add("Pictures", listView1.Width / 3, HorizontalAlignment.Left);
            listView1.Columns.Add("Genre", listView1.Width / 3, HorizontalAlignment.Left);
            listView1.Columns.Add("Name of the Anime", listView1.Width / 3, HorizontalAlignment.Left);

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
            imageListSmall.Images.Add(Image.FromFile(@"C:\Users\Devman\Desktop\new.jpg"));
            imageListSmall.Images.Add(Image.FromFile(@"C:\Users\Devman\Desktop\Capture.png"));
            imageListLarge.Images.Add(Image.FromFile(@"C:\Users\Devman\Desktop\new.jpg"));
            imageListLarge.Images.Add(Image.FromFile(@"C:\Users\Devman\Desktop\Capture.png"));
            //Assign the ImageList objects to the ListView.

            // set the siz to the Image
            imageListSmall.ImageSize = new Size(50, 50);
            imageListLarge.ImageSize = new Size(60, 80);

            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;
        
        }
        
    }
}
