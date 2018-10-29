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
            //Application.Run(new PersonalInformationForm(new Person('a')));
            //Application.Run(new AddModifyForm());
<<<<<<< HEAD
            Application.Run(new SelectionViewForm(null));
=======
            //Application.Run(new SelectionViewForm());
            Application.Run(new WelcomeScreen());
>>>>>>> 44b5b7045845444ecd788e04b0d700cd9440fc72
        }
    }
}
