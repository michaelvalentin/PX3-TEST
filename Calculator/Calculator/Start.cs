// -----------------------------------------------------------------------
// <copyright file="Main.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System.Windows;

namespace Calculator
{

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Start
    {
        [System.STAThread]
        public static void Main(string[] args)
        {
            Application app = new Application();
            app.Startup += (object sender, StartupEventArgs e) =>
            {
                MainWindow view = new MainWindow();
                view.Show();
                Controler cont = new Controler(view, new Calc());
            };
            app.Run();
        }
    }
}
