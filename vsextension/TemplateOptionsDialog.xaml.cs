using System.Windows.Controls;

namespace NUnitTemplatesVsix
{
    /// <summary>
    /// Interaction logic for TemplateOptionsDialog.xaml
    /// </summary>
    public partial class TemplateOptionsDialog : DialogWindowBase
    {
        public TemplateOptionsViewModel TemplateOptions { get; }

        public TemplateOptionsDialog()
            : this(new TemplateOptionsViewModel())
        {
        }

        public TemplateOptionsDialog(TemplateOptionsViewModel templateOptions)
        {
            TemplateOptions = templateOptions;
            InitializeComponent();
            DataContext = TemplateOptions;
        }
    }
}
