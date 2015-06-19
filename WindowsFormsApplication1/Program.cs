using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Weapon largeDagger = new Weapon();
            largeDagger.Name = "Large Dagger";
            largeDagger.BaseCost = 16;
            largeDagger.Tiers.Add(new Tier{Cost=12,Name="Oak"});

            Skill knife = new Skill();
            knife.Name = "Knife";
            knife.Benefits = largeDagger;
            knife.Tiers.Add(new Tier {Cost=5,Name="Novice"});
            knife.Tiers.Add(new Tier { Cost = 10, Name = "Adequate" });
        }
    }
}
