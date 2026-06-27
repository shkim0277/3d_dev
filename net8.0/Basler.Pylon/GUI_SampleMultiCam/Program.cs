/*
    Note: Before getting started, Basler recommends reading the Programmer's Guide topic
    in the pylon .NET API documentation: https://docs.baslerweb.com/pylonapi/net/ 

    This sample illustrates how to operate two cameras using a viewer GUI. 
	This can be used as an example for implementing multi-camera setups. 
*/

using System;
using System.Windows.Forms;

namespace GUISampleMultiCam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Make friendly names unique.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
