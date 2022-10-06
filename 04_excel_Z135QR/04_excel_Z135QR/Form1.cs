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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace _04_excel_Z135QR
{
    public partial class Form1 : Form
    {
        RealEstateEntities context = new RealEstateEntities(); 
        List<Flat> Flats; 
        public Form1()
        {
            
            InitializeComponent();

        }
        private void LoadData()
        {
            List<Flat> Flats = context.Flat.ToList(); //problemas
        }
    }
}
