using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Commands;
using Prism.Mvvm;

namespace SnippingTool.ViewModels
{
    class ShellViewModel : BindableBase
    {
        public DelegateCommand CaptureCommand { get; }

        public ShellViewModel()
        {
            CaptureCommand = new DelegateCommand(Capture);
        }

        public void Capture()
        {

        }
    }
}
