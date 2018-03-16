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
using System.IO;

namespace SnippingTool.ViewModels
{
    class ShellViewModel : BindableBase
    {
        private BitmapSource bmp;
        public BitmapSource Bmp
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
            childWindow.ShowDialog();
            
            string fullPath = System.IO.Path.GetFullPath("capture.png");

            using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
            {
                // FileStreamからBitmapDecoderを作成します。
                // BitmapCacheOptionをOnLoadにすることで画像データをメモリにキャッシュします。
                var decoder = BitmapDecoder.Create(fs, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);

                Bmp = decoder.Frames[0];
            }

        }
    }
}
