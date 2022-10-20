using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using webszolgaltatas_05.Entities;
using webszolgaltatas_05.MnbServiceReference;

namespace webszolgaltatas_05
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates;
        public Form1()
        {
            InitializeComponent();

            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };
            //ujra commitolom, hogy a 02/03 as lepes elkulonuljon
            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

             void xmlFeldolgozas()
            {
                var xml = new XmlDocument();
                xml.LoadXml(result);


                foreach (XmlElement element in xml.DocumentElement)
                {
                    var rate = new RateData();
                    Rates.Add(rate);

                    rate.Date = DateTime.Parse(element.GetAttribute("date"));

                    var childElement = (XmlElement)element.ChildNodes[0];
                    rate.Currency = childElement.GetAttribute("curr");

                    var unit = decimal.Parse(childElement.GetAttribute("unit"));
                    var value = decimal.Parse(childElement.InnerText);
                    if (unit != 0)
                        rate.Value = value / unit;
                }
            }
        }
        
        
    }
}
