﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
namespace Крестики_нолики
{

    
    static class Program
    {

        

        [STAThread]

   
        static void Main()
        {

           



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }
    }
}
