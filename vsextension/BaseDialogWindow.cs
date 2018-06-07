using Microsoft.VisualStudio.PlatformUI;

namespace NUnitTemplatesVsix
{
    public class BaseDialogWindow : DialogWindow
    {
        public BaseDialogWindow()
        {
            HasMaximizeButton = false;
            HasMinimizeButton = false;
        }
    }
}
