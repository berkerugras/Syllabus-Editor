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

namespace Modelling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //berker
            this.Hide();
            var Editor = new Editor();
            Editingpage edp = new Editingpage();
            //edp.IsOpen = 0;
            Editor.Engprop = 0;
            Editor.Closed += (s, args) => this.Close();
            Editor.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                { //berker

                    Uri uri = new Uri(ofd.FileName);
                    Editor obj = new Editor();
                    Editingpage edp = new Editingpage(uri.LocalPath);
                    edp.IsOpen = 1;
                    obj.MyProperty = uri.LocalPath;
                    obj.Closed += (s, args) => this.Close();
                    obj.Show();

                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); //berker
            var Editor = new Editor();
            Editingpage edp = new Editingpage();
            //edp.IsOpen = 0;

            Editor.Engprop = 0;
            Editor.Closed += (s, args) => this.Close();
            Editor.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    Uri uri = new Uri(ofd.FileName); //berker
                    Editor obj = new Editor();
                    //Editingpage edp = new Editingpage(uri.LocalPath);
                    //edp.IsOpen = 1; 
                    obj.Engprop = 0;
                    obj.MyProperty = uri.LocalPath;
                    obj.Closed += (s, args) => this.Close();
                    obj.Show();

                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //berker
            var Editor = new Editor();
            Editor.Engprop = 1;
            //Editingpage edp = new Editingpage();
            //edp.IsOpen = 0;
            Editor.Closed += (s, args) => this.Close();
            Editor.Show();

        }

        private void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();  //berker
            var Editor = new Editor();
            //Editingpage edp = new Editingpage();
            //edp.IsOpen = 0;
            Editor.Engprop = 0;
            Editor.Closed += (s, args) => this.Close();
            Editor.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var Msg = new Message("Some String here", "Title of Message Box");
            MessageBox.Show("This software is works on only Windows devices and it is created by Berker Uğraş, Begüm Şencan, İbrahim Utku Sarıçan.","About");
        }
    }
}