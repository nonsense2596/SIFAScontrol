//using System;
//using System.Diagnostics;
//using System.Windows.Forms;
//using System.Runtime.InteropServices;
//using System.Drawing;
//using System.Threading;


//class InterceptKeys
//{






//    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
//    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
//    //Mouse actions
//    private const int MOUSEEVENTF_LEFTDOWN = 0x02;
//    private const int MOUSEEVENTF_LEFTUP = 0x04;
//    private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
//    private const int MOUSEEVENTF_RIGHTUP = 0x10;

//    public static void DoMouseClick()
//    {
//        //Call the imported function with the cursor's current position
//        uint X = (uint)Cursor.Position.X;
//        uint Y = (uint)Cursor.Position.Y;
//        //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
//        mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
//    }
//    public static void DoMouseClick2()
//    {
//        //Call the imported function with the cursor's current position
//        uint X = (uint)Cursor.Position.X;
//        uint Y = (uint)Cursor.Position.Y;
//        //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
//        mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
//    }





//    [DllImport("User32.dll")]
//    public static extern IntPtr GetDC(IntPtr hwnd);
//    [DllImport("User32.dll")]
//    public static extern void ReleaseDC(IntPtr hwnd, IntPtr dc);





//    private const int WH_KEYBOARD_LL = 13;
//    private const int WM_KEYDOWN = 0x0100;
//    private static LowLevelKeyboardProc _proc = HookCallback;
//    private static IntPtr _hookID = IntPtr.Zero;

//    public static void InitializeComponent()
//    {
//        _hookID = SetHook(_proc);
//        Application.Run();
        
//        UnhookWindowsHookEx(_hookID);
//    }

//    private static IntPtr SetHook(LowLevelKeyboardProc proc)
//    {
//        using (Process curProcess = Process.GetCurrentProcess())
//        using (ProcessModule curModule = curProcess.MainModule)
//        {
//            return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
//                GetModuleHandle(curModule.ModuleName), 0);
//        }
//    }

//    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

//    private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
//    {
//        if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
//        {
//            int vkCode = Marshal.ReadInt32(lParam);


//            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
//            Console.WriteLine((Keys)vkCode + " " + milliseconds);

//        }

//        return CallNextHookEx(_hookID, nCode, wParam, lParam);
//    }

//    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

//    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    [return: MarshalAs(UnmanagedType.Bool)]
//    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

//    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

//    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    private static extern IntPtr GetModuleHandle(string lpModuleName);













//}