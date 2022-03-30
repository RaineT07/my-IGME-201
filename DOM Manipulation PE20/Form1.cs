using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOM_Manipulation_PE20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }
            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // if you want to use example.html from a local folder (saved in c:\temp for example):
            //this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");


        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");
            htmlElementCollection[0].InnerText = "My UFO Page";
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");
            htmlElementCollection[0].InnerText = "My UFO Info";
            htmlElementCollection[1].InnerText = "My UFO Pictures";
            htmlElementCollection[2].InnerText = "";

            htmlElement = webBrowser.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #800000;";
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElementCollection[0].InnerHtml = "Report your UFO sightings here:<a href=\"http://www.nuforc.org\">www.nuforc.org</a>";
            htmlElementCollection[0].Style += "color: green;";
            htmlElementCollection[0].Style += "font-weight: bold;";
            htmlElementCollection[0].Style += "font-size: 2em;";
            htmlElementCollection[0].Style += "text-transform: uppercase;";
            htmlElementCollection[0].Style += "text-shadow: 3px 2px #A44;";
            htmlElementCollection[1].InnerText = "";

            HtmlElement imgHtmlElement = webBrowser.Document.CreateElement("img");
            imgHtmlElement.SetAttribute("src", "https://i.guim.co.uk/img/media/26b02e1ade06fad41b87e5ef02f65bafb719acda/0_274_4456_2673/master/4456.jpg?width=620&quality=85&auto=format&fit=max&s=205151395637655cb628f33abf3b0c87");
            imgHtmlElement.SetAttribute("title", "We are not alone!");
            htmlElement = webBrowser.Document.GetElementById("lastParagraph");
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, imgHtmlElement);


            HtmlElement footHtmlElement = webBrowser.Document.CreateElement("FOOTER");
            footHtmlElement.SetAttribute("id", "tester");
            footHtmlElement.SetAttribute("title", "this is a test");
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterEnd, footHtmlElement);
            htmlElement = webBrowser.Document.GetElementById("tester");
            htmlElement.InnerHtml = "©2022 R. Taber";

        }

    }
}
