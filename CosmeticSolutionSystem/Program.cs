﻿using CosmeticSolutionSystem.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmeticSolutionSystem
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*
                        List<Sale> list = SalesDao.GetById();
                        foreach(var item in list)
                        {
                            Debug.WriteLine(item.Time);

                        }*/

            Application.Run(new MainForm());
        }
    }
}
