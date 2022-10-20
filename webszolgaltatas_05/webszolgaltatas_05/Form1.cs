﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }
        
    }
}
