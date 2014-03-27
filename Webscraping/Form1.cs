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
        List<FMStation> stations;
        WebScraper scraper = new WebScraper();
        public Form1()
        {
            InitializeComponent();
            stations = new List<FMStation>();
        }

        private void btnHaalFrequenciesOp_Click(object sender, EventArgs e)
        {
            stations = scraper.GetListOfStations();

            for (int i = 0; i < stations.Count; i++)
            {
                //int n = GVFrequencies.Rows.Add();
                //GVFrequencies.Rows[i].Cells[0].Value = stations[i].MHz;
                //GVFrequencies.Rows[i].Cells[1].Value = stations[i].Omroep;
                //GVFrequencies.Rows[i].Cells[2].Value = stations[i].OmroepLocatie;
                GVFrequencies.Rows.Insert(i, stations[i].MHz, stations[i].Omroep, stations[i].OmroepLocatie);
            }
        }


    }

    #region POC-HtmlAgilityPack
    //String loc = "C:\\Users\\Dwight\\Downloads\\Htmldoc.html";
    //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument(); /* HtmlWeb.Load */
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
