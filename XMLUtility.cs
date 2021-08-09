using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataStructuresAndAlgorithms
{
    class EmployeeTransfer
    {
        public string FromBUID { get; set; }

        public string ToBUID { get; set; }

        public string TransferDate { get; set; }

        public string EmployeeID { get; set; }

    }
    class XMLUtility
    {
        public static void GenerateXML()
        {
            List<EmployeeTransfer> li = new List<EmployeeTransfer>();

            li.Add(new EmployeeTransfer
            {
                EmployeeID = "10001",
                FromBUID = "1234",
                ToBUID = "9876",
                TransferDate = "07/24/2021"
            });
            XmlDocument xml = new XmlDocument();
            XmlElement root = xml.CreateElement("WFMEmployeeTransferInterface");
            root.SetAttribute("CreationSource", "Tesco System");
            xml.AppendChild(root);
            foreach (var cust in li)
            {
                XmlElement child = xml.CreateElement("EmployeeTransfer");
                child.SetAttribute("FromBUID", cust.FromBUID);
                child.SetAttribute("ToBUID", cust.ToBUID);
                child.SetAttribute("TransferDate", cust.TransferDate);
                child.SetAttribute("EmployeeID", cust.EmployeeID);
                root.AppendChild(child);
            }

            if(File.Exists(@"test.xml"))
            {
                File.Delete(@"test.xml");
            }

            using(var streamWriter = new StreamWriter(@"test.xml"))
            {
                streamWriter.Write(xml.InnerXml);
            }

        }
    }
}
