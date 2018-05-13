using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrototypeDLL;
using TYK.ServiceReference1;

namespace TYK
{
    class Program
    {
        public delegate void myDelegate();
        public event myDelegate getInfo;
        public event myDelegate getInfoS;
        
       

        internal BasicUserMenu BasicUserMenu
        {
            get => default(BasicUserMenu);
            set
            {
            }
        }

        internal UIStyleDecorator UIStyleDecorator
        {
            get => default(UIStyleDecorator);
            set
            {
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            Teacher teacher = new Teacher(1, 1);
            Student student = new Student(2);
            WebServiceSoapClient n = new WebServiceSoapClient();
            

            string res;
            res = Console.ReadLine();
            program.getInfo += teacher.GetInfo;
            program.getInfoS += student.GetInfo;
            if (res == "1")
            {
                program.getInfo();
            }
            else if (res == "2")
            {
                program.getInfoS();
            }
            else
                Console.WriteLine("error");

        
            
            //teacher.getInfo += ();
            BasicUserMenu bum = new BasicUserMenu();
            bum.WelomeText();
            n.HelloWorld();
            Console.WriteLine(n.HelloWorld());

            FileManager fm = new FileManager();
            fm.ResultsWrite();
            bum.AnswersWrittenSucc();
            bum.DecoratorDemo();

            UIStyle User1 = new PhysicsUI();
            User1 = new NAUStyle(User1);    // PHYS NAU   exp 1896 + 200 = 2096
            Console.WriteLine("Test Information: {0}", User1.Name);
            Console.WriteLine("Code: {0}", User1.GetColor());

            UIStyle User2 = new PhysicsUI();
            User2 = new KPIStyle(User2);    // PHYS KPI exp 1896 + 350 = 2246
            Console.WriteLine("Test Information: {0}", User2.Name);
            Console.WriteLine("Code: {0}", User2.GetColor());

            UIStyle User3 = new MathUI();
            User3 = new NAUStyle(User3);
            User3 = new KPIStyle(User3);    // MATH NAU KPI exp 2001 + 350 + 200 = 2551
            Console.WriteLine("Test Infromation: {0}", User3.Name);
            Console.WriteLine("Code: {0}", User3.GetColor());

            Console.ReadLine();
        }
    }

    abstract class UIStyle
    {
        public UIStyle(string n)
        {
            this.Name = n;
        }
        public string Name { get; set; }
        public abstract int GetColor();
    }

    class PhysicsUI : UIStyle
    {
        public PhysicsUI() : base("PhysicsUI")
        { }
        public override int GetColor()
        {
            return 1896;
        }
    }
    class MathUI : UIStyle
    {
        public MathUI() : base("MathUI")
        { }
        public override int GetColor()
        {
            return 2001;
        }
    }

    abstract class UIStyleDecorator : UIStyle
    {
        protected UIStyle style;
        public UIStyleDecorator(string n, UIStyle style) : base(n)
        {
            this.style = style;
        }
    }

    class NAUStyle : UIStyleDecorator
    {
        public NAUStyle(UIStyle p) : base(p.Name + ", NAU", p)
        { }

        public override int GetColor()
        {
            return style.GetColor() + 200;
        }
    }

    class KPIStyle : UIStyleDecorator
    {
        public KPIStyle(UIStyle p)
            : base(p.Name + ", KPI", p)
        { }

        public override int GetColor()
        {
            return style.GetColor() + 350;
        }
    }
}