using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Windows;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Reflection;

namespace Modelling
{
    public partial class Editor : Form
    {
        public int Engprop { get; set; }
        public string MyProperty { get; set; }
        public Editor()
        {
           InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;

        }
       
        private void Editor_Load(object sender, EventArgs e)
        {
            string yol = Application.StartupPath;
            string temp = yol + "\\Syllabustmp\\TurkishTemplateEdited.html";
            string eng = yol + "\\Syllabustmp\\EnglishTemplateEdited.html";


            if (Engprop==1)
            {
                
                webBrowser1.Navigate(eng);

            }
            if (MyProperty != temp && Engprop != 1)
            {

                webBrowser1.Navigate(MyProperty);
            }

            if(MyProperty==null && Engprop !=1)
            {
                webBrowser1.Navigate(temp);
            }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();


            var html = httpClient.GetStringAsync(textBox1.Text); // get isteği gönderir ve onu stringe çevirir
            string yol = Application.StartupPath;
            string b = html.Result;
            System.IO.Directory.CreateDirectory(yol+"\\Syllabustmp\\imported");
            File.WriteAllText(yol + "\\Syllabustmp\\imported\\website.htm", b);
            File.WriteAllText(yol + "\\Syllabustmp\\imported\\website.txt", b);
            MessageBox.Show("Your syllabus files are successfully imported !");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }



    

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //berker
            string yol = Application.StartupPath;
            string temp = yol + "\\Syllabustmp\\TurkishTemplateEdited.html";
            string eng = yol + "\\Syllabustmp\\EnglishTemplateEdited.html";

            var Edit = new Editingpage();
            if (MyProperty == null && Engprop == 1)
            {
                Edit = new Editingpage(eng);
                Edit.IsOpen = 1; //for eng temp
                Edit.IsEng = 1;
                Edit.Show();
            }
            if (MyProperty != temp && Engprop != 1 && MyProperty != null)
            {
                Edit = new Editingpage(MyProperty);
                Edit.IsOpen = 1; //for open
                Edit.IsEng = 0;
                Edit.Show();
            }

            if (MyProperty == null && Engprop != 1)
            {
                Edit.IsOpen = 0; //for tr temp
                Edit.IsEng = 0;
                Edit.Show();

            }
        }
    }
}
