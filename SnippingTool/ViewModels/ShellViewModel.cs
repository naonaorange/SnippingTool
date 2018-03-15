using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SnippingTool.Views;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace SnippingTool.ViewModels
{
    class ShellViewModel : BindableBase
    {
        public IRegionManager RegionManager { get; set; }

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
