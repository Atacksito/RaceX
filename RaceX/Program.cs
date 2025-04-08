// Program.cs
using RaceXSimulator.Forms;
using System;
using System.Windows.Forms;

namespace RaceXSimulator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}