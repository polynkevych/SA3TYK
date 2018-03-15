using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYK
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicUserMenu bum = new BasicUserMenu();
            bum.WelomeText();

            FileManager fm = new FileManager();
            fm.ResultsWrite();

            UIStyle User1 = new PhysicsUI();
            User1 = new NAUStyle(User1);    // PHYS NAU   exp 1896+200 = 2096
            Console.WriteLine("Test Information: {0}", User1.Name);
            Console.WriteLine("Code: {0}", User1.GetColor());

            UIStyle User2 = new PhysicsUI();
            User2 = new KPIStyle(User2);    // PHYS KPI exp 1896+350 = 2246
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
        public string Name { get; protected set; }
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