using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alchemy
{
    struct element 
    {
        public string name;
        public bool is_visible;

        public void getName(string name)
        {
            this.name = name;
        }
        public void getVision(bool vis)
        {
            this.is_visible = vis;
        }
    }

    

    
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menu());
        }
    }
}
