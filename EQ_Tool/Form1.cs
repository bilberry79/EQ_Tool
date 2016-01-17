using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EQ_Tool
{
    public partial class Form1 : Form
    {

        private UserLocation userLocationJSON;
        private UserLocation userLocation;
        private EQ_Data eq_data;
        private List<EQ_ListData> eq_list;

        public Form1()
        {
            InitializeComponent();
            
            EQInfo_label1.Text = "";
            EQInfo_label2.Text = "";
            EQInfo_label3.Text = "";
            EQInfo_label4.Text = "";
            Today_label.Text = "Today: " + DateTime.Now.ToString("dd.MMMM");
            my_dyn_loc_label1.Text = "";
            location_linkLabel1.Text = "";

            // A list for the quakes
            eq_list = new List<EQ_ListData>();
            userLocationJSON = new UserLocation();
            
            try
            {
                // Get user location data from the interweb
                userLocation = userLocationJSON._download_serialized_json_data<UserLocation>("http://ipinfo.io/json");
                // Get the quake data from the interweb
                eq_data = new EQ_Data();
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("No interweb. Me need interweb to work.", "Copmuter says no!", MessageBoxButtons.OK);
                // Disable the button if there's no internet connection.
                Get_button.Enabled = false;
                
            }

            // Display the user location.
            my_dyn_loc_label1.Text = "You are in "+ userLocation.city;

        }

        private void Get_button_Click(object sender, EventArgs e)
        {
            // Reset the form each time you click the button.
            // Clear the labels each time you click the button.
            EQInfo_label1.Text = "";
            EQInfo_label2.Text = "";
            EQInfo_label3.Text = "";
            EQInfo_label4.Text = "";
            location_linkLabel1.Text = "";
            location_linkLabel1.Links.Clear();
            this.Height = 157;

            // Gets the quake date and stores it in the list
            eq_list = eq_data.getDataAboutQuakes();

            foreach (EQ_ListData item in eq_list)
            {
                // Obsolete: city names are in a link label now.
                //EQInfo_label1.Text += item.formatedDescription() + "\n";
                location_linkLabel1.Links.Add(location_linkLabel1.Text.Length, item.formatedDescription().Length, "https://www.google.co.jp/maps/@" + item.latitude + "," + item.longitude + "," + "10z");
                location_linkLabel1.Text += item.formatedDescription() + "\n";
                EQInfo_label2.Text += item.date.ToString("dd.MMMM, hh:mm") + "\n";
                EQInfo_label3.Text += item.magnitude + "\n";
                // If you convert a string to decimal, use InvariantCulture to stop mess with decimal dot or comma!
                // Get the distance of the quakes in Japan relative to your current location
                EQInfo_label4.Text += Math.Round(eq_data.distance(userLocation.getLatAndLong()[0], userLocation.getLatAndLong()[1], Convert.ToDouble(item.latitude, System.Globalization.CultureInfo.InvariantCulture), Convert.ToDouble(item.longitude, System.Globalization.CultureInfo.InvariantCulture), 'K'), 2) + "\n"; 
            }

            // this.Height is the hight of the Application form itself.
            // the hight will increased by the height of the list of quakes. 
            // some kind of auto adjust.
            this.Height += location_linkLabel1.Height;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void location_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            location_linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
