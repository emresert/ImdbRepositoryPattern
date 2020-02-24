using HtmlAgilityPack;
using ImdbData.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImdbUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        List<Writer> WriterList = new List<Writer>();
        List<Director> DirectorList = new List<Director>();
        List<Star> StarList = new List<Star>();
        HtmlWeb web = new HtmlWeb();
        string part;
        public Form3(List<Writer> _Writer)
        {

            WriterList = _Writer;

            InitializeComponent();
        }
        public Form3(List<Director> _Director)
        {

            DirectorList = _Director;

            InitializeComponent();
        }
        public Form3(List<Star> _Star)
        {

            StarList = _Star;

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (DirectorList.Count > 0)
            {
                foreach (var item in DirectorList)
                {
                    lbxNameSurname.Items.Add(item.NameSurname);
                }
                part = "d";

            }
            if (WriterList.Count > 0)
            {
                foreach (var item in WriterList)
                {
                    lbxNameSurname.Items.Add(item.NameSurname);
                }
                part = "w";
            }
            if (StarList.Count > 0)
            {
                foreach (var item in StarList)
                {
                    lbxNameSurname.Items.Add(item.NameSurname);
                }
                part = "s";
            }
        }

        private void lbxNameSurname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int id = lbxNameSurname.SelectedIndex;

                string _link = "";
                string info = "";
                string imgInfo = "";
                string bornDate, bornPlace;
                if (part == "s")
                {
                    _link = StarList[id].starLink;
                }
                else if (part == "w")
                {
                    _link = WriterList[id].writerLink;
                }
                else if (part == "d")
                {
                    _link = DirectorList[id].directorLink;
                }


                HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.imdb.com" + _link);
                string xPathForInfo = "//*[@id=\"name-bio-text\"]/div";
                string xPathForimgInfo = "//*[@id=\"name-poster\"]";
                string xPathForBorn = "//*[@id=\"name-born-info\"]";
                HtmlNode node = doc.DocumentNode.SelectSingleNode(xPathForInfo);
                HtmlNode nodeTwo = doc.DocumentNode.SelectSingleNode(xPathForimgInfo);
                HtmlNode nodeTree = doc.DocumentNode.SelectSingleNode(xPathForBorn);

                foreach (var item in node.ChildNodes)
                {
                    if (item.Name == "div")
                    {
                        info = item.InnerText;
                        info = info.Replace("See full bio &raquo;", "").Trim();
                        rtbxInfo.Text = info;
                    }
                }
                if (nodeTwo.Name == "img")
                {
                    imgInfo = nodeTwo.OuterHtml;
                    imgInfo = imgInfo.Replace("src=\"", "#");
                    imgInfo = imgInfo.Replace("\">", "*");
                    int indexOne, indexTwo;
                    indexOne = imgInfo.IndexOf("#", 0);
                    indexTwo = imgInfo.IndexOf("*", 0);
                    imgInfo = imgInfo.Substring(indexOne + 1, (indexTwo - indexOne) - 1);
                    pcxImageInfo.ImageLocation = imgInfo;
                }

                foreach (var item in nodeTree.ChildNodes)
                {
                    if (item.Name == "time")
                    {
                        bornDate = item.InnerText;
                        bornDate = bornDate.Replace(" ", "").Trim();
                        bornDate = bornDate.Replace("\n", "").Trim();
                        lblBornDate.Text = bornDate;
                    }
                    else if (item.Name == "a")
                    {
                        bornPlace = item.InnerText.Trim();
                        lblBornDate.Text = lblBornDate.Text + " " + bornPlace;
                    }

                }

                lblNameSurnameInfo.Text = lbxNameSurname.GetItemText(lbxNameSurname.SelectedItem);

            }
            catch
            {
                MessageBox.Show("Something went wrong");

            }
        }
    }
}
