using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using HtmlAgilityPack;

namespace Webscraping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHaalFrequenciesOp_Click(object sender, EventArgs e)
        {
        }


    }

    #region POC-HtmlAgilityPack
    //String loc = "C:\\Users\\Dwight\\Downloads\\Htmldoc.html";
    //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
    //
    //    doc.Load(loc);
    //    foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//td"))
    //    {
    //        textBox1.Text += link.InnerText + "\n               ";
    //        //textBox1.Text +=  link.Attributes["href"].Value + "\n                 ";
    //    }
    //
    #endregion POC-HtmlAgilityPack
}
