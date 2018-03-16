using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYK
{
    class BasicUserMenu
    {
        internal FileManager FileManager
        {
            get => default(FileManager);
            set
            {
            }
        }

        public void WelomeText()
        {
            Console.Write("Hello and welcome to Test Your Knowledge v1.0\n" +
                "Enter your answer below\n" +
                "After press enter \n");
        }

        public void AnswersWrittenSucc()
        {
            Console.WriteLine("Answers had been written succesfully!\n");
        }
        public void DecoratorDemo()
        {
            Console.Write("Decorator implementation\n" +
                "****************************\n");
        }
    }
}
