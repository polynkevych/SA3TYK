using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDLL
{

   public interface IUser
    {
        IUser Clone();
        void GetInfo();
    }

    public class Teacher : IUser 
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
            Console.WriteLine("Teacher with access to read test {0} and write results {1}", testAcess, answerAcess);
        }
    }

    public class Student : IUser 
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
            Console.WriteLine("Student logged with number {0}", testPass);
        }
    }
}
