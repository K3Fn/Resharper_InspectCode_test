using ClassLibrary1;

namespace WindowsAppNet6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            var commonClass = new CommonClass(100);
            Text1.Text = commonClass.UsedByNet6Windows().ToString();
        }
    }
}
