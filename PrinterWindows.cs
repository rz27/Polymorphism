using System;
namespace tugaspolymorphism
{
    public class PrinterWindows
    {
        public string Printer { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("ini printer");
        }
        public virtual void Print()
        {
            Console.WriteLine("printing....");
        }

    }
}
