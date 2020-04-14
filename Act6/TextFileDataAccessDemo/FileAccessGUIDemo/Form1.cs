using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAccessGUIDemo
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        string path = @"D:\work\guiTest.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void personButt_Click(object sender, EventArgs e)
        {
            if (fNameBox.Text != null && lNameBox.Text != null && occBox.Text != null && fNameBox.Text != "" && lNameBox.Text != "" && occBox.Text != "")
            {
                Person p = new Person();
                p.firstName = fNameBox.Text;
                p.lastName = lNameBox.Text;
                p.occupation = occBox.Text;
                people.Add(p);
            }
            else
            {
                MessageBox.Show("Please fill out all 3 texts");
            }
        }

        private void saveButt_Click(object sender, EventArgs e)
        {
            List<String> outlines = new List<String>();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            foreach (Person p in people)
            {
                outlines.Add("First Name: " + p.firstName + " ||Last Name: " + p.lastName + " ||Occupation: " + p.occupation);
            }
            File.WriteAllLines(path, outlines);
        }

        private void loadButt_Click(object sender, EventArgs e)
        {
            List<Person> peep = new List<Person>();
            List<String> lines = File.ReadAllLines(path).ToList();
            listBox1.DataSource = lines;
            foreach (String line in lines)
            {
                string[] s = line.Split(' ');
                Person p = new Person();
                p.firstName = s[2];
                p.lastName = s[5];
                p.occupation = s[7];
                peep.Add(p);
            }
            people = peep;
        }
    }
}
