﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldsHardestGame;

namespace evolucios_algoritmus
{
    public partial class Form1 : Form
    {
  
            GameController gc = new GameController();
            GameArea ga;
            int populationSize = 250;
            int nbrOfSteps = 10;
            int nbrOfStepsIncrement = 10;
            int generation = 1;

        public Form1()
            {
                InitializeComponent();

                ga = gc.ActivateDisplay();
                

            for (int i = 0; i < populationSize; i++)
            {
                gc.AddPlayer(nbrOfSteps);
            }
            this.Controls.Add(ga);
            gc.Start();
            
            //gc.AddPlayer();
            //gc.Start(true);
        }
    }
}
