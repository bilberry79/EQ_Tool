using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;

namespace EQ_Tool
{
    public class EQ_Data
    {
        //!! get xml data in load fuktion: 
        private string now = DateTime.Now.ToString("yyyy-MM-dd");
        private string lastWeek = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd");
        private XmlDocument eq_lastweek_xml;
        private XmlNamespaceManager nsmgr;
        private List<EQ_ListData> eq_list;

        public EQ_Data()
        {
            loadXml();
        }

        // Loads the XML data 
        private void loadXml()
        {
            // Load content from the URI in the XMLDocument
            // Get Japan's quakes of past week
            eq_lastweek_xml = new XmlDocument();
            eq_lastweek_xml.Load("http://earthquake.usgs.gov/fdsnws/event/1/query?format=xml&minlatitude=29.6903336&minlongitude=128.9653145&maxlatitude=45.5502371&maxlongitude=150.1024073&starttime=" + lastWeek + "&endtime=" + now);
            // Get the namespaces of the XML
            nsmgr = new XmlNamespaceManager(eq_lastweek_xml.NameTable);
            // Add the name spaces (help from XPath Visualizer Tool!)
            nsmgr.AddNamespace("q", "http://quakeml.org/xmlns/quakeml/1.2");
            nsmgr.AddNamespace("catalog", "http://anss.org/xmlns/catalog/0.1");
            nsmgr.AddNamespace("ns1", "http://quakeml.org/xmlns/bed/1.2");
        }

        public XmlNamespaceManager getNsmgr()
        {
            return nsmgr;
        }

        // Get all Information of the quakes
        public XmlNodeList getJapanQuakes()
        {
            // Get the Quakes stored in the 'event' node. All
            XmlNodeList eq_Nodes = eq_lastweek_xml.SelectNodes("//q:quakeml/ns1:eventParameters/ns1:event", nsmgr);
            return eq_Nodes;
        }
        
        // Stores the quake data from the XML in a list and returns the collection.
        // It's a list that holds elements of type EQ_ListData
        public List<EQ_ListData> getDataAboutQuakes()
        {
            eq_list = new List<EQ_ListData>();
            // Get the XML Nodes with the quake events
            XmlNodeList eq_Nodes = eq_lastweek_xml.SelectNodes("//q:quakeml/ns1:eventParameters/ns1:event", nsmgr);
           
            // Go through all quake events
            // and add them to the eq_list!
            foreach (XmlNode eq_node in eq_Nodes)
            {
                // Data type for quake information
                // It contains: description, time and magnitude
                EQ_ListData quake_element = new EQ_ListData();
                // Store the single information in the EQ_ListData Type
                
                quake_element.description = eq_node.SelectSingleNode("ns1:description/ns1:text", nsmgr).InnerText;
                quake_element.date = Convert.ToDateTime(eq_node.SelectSingleNode("ns1:origin/ns1:time/ns1:value", nsmgr).InnerText);
                quake_element.magnitude = eq_node.SelectSingleNode("ns1:magnitude/ns1:mag/ns1:value", nsmgr).InnerText;
                quake_element.longitude = eq_node.SelectSingleNode("ns1:origin/ns1:longitude/ns1:value", nsmgr).InnerText;
                quake_element.latitude = eq_node.SelectSingleNode("ns1:origin/ns1:latitude/ns1:value", nsmgr).InnerText;
                // Add a new element to the list.
                eq_list.Add(quake_element);        
            }

            return eq_list;
        }

        // Calculate distance between to points of lat and lon
        // Got it from here: www.geodatasource.com/developers/c-sharp
        public double distance(double lat1, double lon1, double lat2, double lon2, char unit)
        {
            double theta = lon1 - lon2;
            double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            if (unit == 'K')
            {
                dist = dist * 1.609344;
            }
            else if (unit == 'N')
            {
                dist = dist * 0.8684;
            }
            return (dist);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts decimal degrees to radians             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        //::  This function converts radians to decimal degrees             :::
        //:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        private double rad2deg(double rad)
        {
            return (rad / Math.PI * 180.0);
        }

    }
}
