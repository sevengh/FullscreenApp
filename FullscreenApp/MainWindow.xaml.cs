using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FullscreenApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Application folder name
        /// </summary>
        static readonly string AppNameFolder = "FullscreenApp";

        /// <summary>
        /// App images path
        /// </summary>
        public readonly static string FolderPathImages = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            AppNameFolder,
            "Images");

        public MainWindow()
        {
            InitializeComponent();

            var filenameImage = Path.Combine(FolderPathImages, @"background.jpg");
            Brush background = new ImageBrush(new BitmapImage(new Uri(filenameImage)));
            MainGrid.Background = background;
        }
    }
}
