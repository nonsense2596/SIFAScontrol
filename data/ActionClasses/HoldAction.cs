using SIFAScontrol.Touch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFAScontrol.data.ActionClasses
{
    public class HoldAction : ActionBase
    {
        public override void Action()
        {
            Console.WriteLine("hold action");
        }
        const int MaxTouchCount = 40;
        PointerTouchInfo[] m_contact = new PointerTouchInfo[MaxTouchCount];
        bool flag = true;
        public override void KeyDownAction()
        {
            //Thread t = new Thread(lol);
            //t.Start();
            Console.WriteLine("holddown");
            Random r = new Random();
            var x = r.Next(Area.X_min, Area.X_max);
            var y = r.Next(Area.Y_min, Area.Y_max);
            new Thread(() =>
            {
                flag = true;
                m_contact[0].PointerInfo.PointerType = PointerInputType.Touch;
                
                m_contact[0].PointerInfo.PointerId = (uint)0;
                TouchInjection.InitializeTouchInjection(MaxTouchCount, TouchFeedback.Indirect);
                m_contact[0].PointerInfo.PointerFlags = PointerFlags.InRange | PointerFlags.InContact | PointerFlags.Down;
                m_contact[0].PointerInfo.PixelLocation.X = (int)x;  //960 teszt
                m_contact[0].PointerInfo.PixelLocation.Y = (int)y;  //960 teszt
                TouchInjection.InjectTouchInput(1, m_contact);
                while (flag)
                {
                    m_contact[0].PointerInfo.PointerFlags = PointerFlags.InRange | PointerFlags.InContact | PointerFlags.Update;
                    TouchInjection.InjectTouchInput(1, m_contact);
                    Thread.Sleep(20);
                }
            }).Start();
        }

        public override void KeyUpAction()
        {
            flag = false;
            m_contact[0].PointerInfo.PointerFlags = PointerFlags.Up;
            TouchInjection.InjectTouchInput(1, m_contact);
        }

        public override void StateChangedAction()
        {
            throw new NotImplementedException();
        }
    }
}


/*public void lol()
{
    flag = true;
    m_contact[0].PointerInfo.PointerType = PointerInputType.Touch;
    m_contact[0].PointerInfo.PointerId = (uint)0;
    TouchInjection.InitializeTouchInjection(MaxTouchCount, TouchFeedback.Default);
    m_contact[0].PointerInfo.PointerFlags = PointerFlags.InRange | PointerFlags.InContact | PointerFlags.Down;
    m_contact[0].PointerInfo.PixelLocation.X = (int)960;
    m_contact[0].PointerInfo.PixelLocation.Y = (int)960;
    TouchInjection.InjectTouchInput(1, m_contact);
    while (flag)
    {
        m_contact[0].PointerInfo.PointerFlags = PointerFlags.InRange | PointerFlags.InContact | PointerFlags.Update;
        TouchInjection.InjectTouchInput(1, m_contact);
        Thread.Sleep(20);
    }
}*/
