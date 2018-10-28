using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenealoTree
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            


            Person person = new GenealoTree.Person();
            person.birthDate = "09021995";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PersonalInformationForm());
            //Application.Run(new AddModifyForm());
            Application.Run(new SelectionViewForm());
        }
    }
}
