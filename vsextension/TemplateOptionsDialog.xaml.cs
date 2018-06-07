using System;
using System.Windows;

namespace NUnitTemplatesVsix
{
    /// <summary>
    /// Interaction logic for TemplateOptionsDialog.xaml
    /// </summary>
    public partial class TemplateOptionsDialog : BaseDialogWindow
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

        private void CreateTemplateClicked(object sender, RoutedEventArgs e)
        {
            TemplateOptions.UserCanceledTemplateCreation = false;
            Close();
        }

        private void CancelClicked(object sender, EventArgs e)
        {
            TemplateOptions.UserCanceledTemplateCreation = true;
        }
    }
}
