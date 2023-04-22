using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4接口
{
    // 可按下按键的“协议”
    interface IPressButton
    {
        // 按下某个按键
        void Press(int button);
    }
    // 可插USB的“协议”
    interface IUSB
    {
        // 插USB
        void PlugUSB();
    }

    class 键盘 : IPressButton, IUSB
    {
        public void Press(int b)
        {
            Console.WriteLine("按下键盘" + b + "键");
        }
        public void PlugUSB() { }
    }
    class 鼠标 : IPressButton, IUSB
    {
        public void Press(int b)
        {
            Console.WriteLine("按下鼠标" + b + "键");
        }
        public void PlugUSB() { }
    }
    class 显示器 : IPressButton
    {
        public void Press(int b)
        {
            Console.WriteLine("按下显示器" + b + "键");
        }
    }
    class 手机 : IPressButton, IUSB
    {
        public void Press(int b)
        {
            Console.WriteLine("按下手机" + b + "键");
        }
        public void PlugUSB() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            键盘 k1 = new 键盘();
            键盘 k2 = new 键盘();
            鼠标 m1 = new 鼠标();
            手机 h1 = new 手机();
            显示器 tv1 = new 显示器();
            显示器 tv2 = new 显示器();
            IPressButton press = m1;

            List<IPressButton> list = new List<IPressButton> {k1,k2, m1, h1, tv1, tv2};

            List<IUSB> list_usb = new List<IUSB>();

            // 按下所有物体的按钮
            foreach (IPressButton obj in list)
            {obj.Press(1);}

            IPressButton kk = k1;
            kk.Press(1);

            // 插鼠标USB
            IUSB usbDevice = m1;
            usbDevice.PlugUSB();

            // 插手机USB
            usbDevice = h1;
            h1.PlugUSB();

            // 插显示器USB，插不了
            //usbDevice = tv2;     // 类型不匹配

            Console.ReadKey();
        }
    }
}
