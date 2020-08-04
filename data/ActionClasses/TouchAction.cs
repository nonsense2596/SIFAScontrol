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
    public class TouchAction: ActionBase
    {
        public override void Action()
        {
            Console.WriteLine("touch action");
            Console.WriteLine(Area.height + " " + Area.width);
        }
        const int MaxTouchCount = 40;
        PointerTouchInfo[] m_contact = new PointerTouchInfo[MaxTouchCount];
        public override void KeyDownAction()
        {
            //Thread t = new Thread(lol);
            //t.Start();
            Random r = new Random();
            var x = r.Next(Area.X_min, Area.X_max);
            var y = r.Next(Area.Y_min, Area.Y_max);
            m_contact[0].PointerInfo.PointerType = PointerInputType.Touch;
            m_contact[0].PointerInfo.PointerId = (uint)0;
            TouchInjection.InitializeTouchInjection(MaxTouchCount, TouchFeedback.Indirect);
            m_contact[0].PointerInfo.PointerFlags = PointerFlags.InRange | PointerFlags.InContact | PointerFlags.Down;
            m_contact[0].PointerInfo.PixelLocation.X = (int)x;
            m_contact[0].PointerInfo.PixelLocation.Y = (int)y;
            TouchInjection.InjectTouchInput(1, m_contact);
            m_contact[0].PointerInfo.PointerFlags = PointerFlags.Up;
            TouchInjection.InjectTouchInput(1, m_contact);
        }
        bool flag = true;
        public void lol()
        {
            /*Random r = new Random();
            var x = r.Next(Area.X_min, Area.X_max);
            var y = r.Next(Area.Y_min, Area.Y_max);

            flag = true;
            
            while (flag)
            {
                m_contact[0].PointerInfo.PointerFlags = PointerFlags.InRange | PointerFlags.InContact | PointerFlags.Update;
                TouchInjection.InjectTouchInput(1, m_contact);
                Thread.Sleep(20);
            }*/

        }
        public override void KeyUpAction()
        {
            //flag = false;
            //m_contact[0].PointerInfo.PointerFlags = PointerFlags.Up;
            //TouchInjection.InjectTouchInput(1, m_contact);
            
            // void
        }

        public override void StateChangedAction()
        {
            // do nothing
        }
    }
}
