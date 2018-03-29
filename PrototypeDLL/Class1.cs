using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDLL
{
   // class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IFigure figure = new Rectangle(30, 40);
    //        IFigure clonedFigure = figure.Clone();
    //        figure.GetInfo();
    //        clonedFigure.GetInfo();

    //        figure = new Circle(30);
    //        clonedFigure = figure.Clone();
    //        figure.GetInfo();
    //        clonedFigure.GetInfo();

    //        Console.Read();
   //     }
   // }

    interface IUser
    {
        IUser Clone();
        void GetInfo();
    }

    class Teacher : IUser //rectangle
    {
        int testAcess;
        int answerAcess;
        public Teacher(int tA, int aA)
        {
            testAcess = tA;
            answerAcess = aA;
        }

        public IUser Clone()    
        {
            return new Teacher(this.testAcess, this.answerAcess);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", testAcess, answerAcess);
        }
    }

    class Student : IUser  //circle
    {
        int testPass;
        public Student(int tP)
        {
            testPass = tP;
        }

        public IUser Clone()
        {
            return new Student(this.testPass);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}", testPass);
        }
    }
}
