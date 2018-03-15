using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SnippingTool.Views;

using Prism.Commands;
using Prism.Mvvm;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace SnippingTool.ViewModels
{
    class ShellViewModel : BindableBase
    {
        private Bitmap bmp;
        public Bitmap Bmp
        {
            get { return bmp; }
            set { SetProperty(ref bmp, value); }
        }

        public DelegateCommand CaptureCommand { get; }

        public ShellViewModel()
        {
            CaptureCommand = new DelegateCommand(Capture);
        }

        public void Capture()
        {
            var childWindow = new CaptureScreen();
            childWindow.Show();
        }
    }
}
