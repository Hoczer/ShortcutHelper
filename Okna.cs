using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikSkrotowy
/// <summary>Class <c>Okna</c> klasa ułatwia używanie API windowsa</summary>
{
    internal class Okna
    {
        [DllImport("User32.dll")]
        public static extern Int32 FindWindow(String lpClassName, String lpWindowName);
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);
        [DllImport("User32.dll")]
        public static extern Boolean EnumChildWindows(int hWndParent, Delegate lpEnumFunc, int lParam);
        [DllImport("User32.dll")]
        public static extern Int32 GetWindowText(int hWnd, StringBuilder s, int nMaxCount);
        [DllImport("User32.dll")]
        public static extern Int32 GetWindowTextLength(int hwnd);
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        public static extern int GetDesktopWindow();
        [DllImport("user32.dll")]
        public static extern Int32 GetClassName(int hWnd, StringBuilder s, int nMaxCount);
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_SHOWWINDOW = 0x0040;
        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);


        /// <summary>ZnajdzOkno <c></c>Wyszukuje i zwraca index okna w systemie</summary>
        public int ZnajdzOkno(string nazwaOkna)
        {
            int hwnd;
            hwnd = FindWindow(null, nazwaOkna);
            return hwnd;
        }
        public void UstawAktywneOkno(int IndexOkna)
        {
            SetForegroundWindow(IndexOkna);
        }
        public string GetNazwaOkna(int IndexOkna)
        {
            StringBuilder nazwaZnalezionegoOkna = new StringBuilder(256);
            GetWindowText(IndexOkna, nazwaZnalezionegoOkna, 256);
            string nazwaOknaStr = nazwaZnalezionegoOkna.ToString().Trim();
            return nazwaOknaStr;
        }
        /// <summary>UstawOknoAllwaysOnTop<c></c>Ustawia okno zawsze na wierzchu, ustawia pozycje i wielkosc okna</summary>
        public void UstawOknoAllwaysOnTop(IntPtr uchwytOkna, bool Tak, int x, int y,int szerokosc,int wysokosc)
        {
            if (Tak)
            {
                SetWindowPos(uchwytOkna, HWND_TOPMOST, x, y, szerokosc, wysokosc, TOPMOST_FLAGS);
            }
            else
            {
                SetWindowPos(uchwytOkna, HWND_NOTOPMOST, x, y, szerokosc, wysokosc, 0);
            }
            
        }
    }
}
