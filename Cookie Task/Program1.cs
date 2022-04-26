using System;

namespace Cookie_Task{

    class Program
    {
        static void Main (string[] args)
        {
            Color Greencolor =new Color(0,255,0,"green");
            Color BlueColor =new Color(0,0,255,"blue");
            Cookie a = new Cookie (200,"circle",Greencolor);
            Cookie b = new Cookie (500,"circle",Greencolor);
            Cookie C = new Cookie (800,"circle",BlueColor);
            Cookie d = new Cookie (100,"square",BlueColor);
            Console.WriteLine(a.getDetails());
        }

    }
}