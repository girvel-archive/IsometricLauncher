using System.Windows.Forms;

namespace Isometric.Launcher
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var i = 1;
            foreach (var screen in Screen.AllScreens)
            {
                ScreenComboBox.Items.Add($"Display {i++} {(screen.Primary ? "(Primary)" : "")}");
            }
        }
    }
}
