using System;
namespace tugaspolymorphism
{
    public class Laserjet:PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("Laserjet printer printing.....  ");
        }

    }
}
