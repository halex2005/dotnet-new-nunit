using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.PlatformUI;

namespace NUnitTemplatesVsix
{
    public class DialogWindowBase : DialogWindow
    {
        public DialogWindowBase()
        {
            HasMaximizeButton = false;
            HasMinimizeButton = false;
        }
    }
}
