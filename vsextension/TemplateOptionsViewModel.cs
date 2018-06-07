using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NUnitTemplatesVsix.Annotations;

namespace NUnitTemplatesVsix
{
    public class TemplateOptionsViewModel : INotifyPropertyChanged
    {
        public KeyValuePair<string, string>[] AvailableFrameworks { get; } =
        {
            new KeyValuePair<string, string>("net35", ".NET Framework 3.5"),
            new KeyValuePair<string, string>("net40", ".NET Framework 4.0"),
            new KeyValuePair<string, string>("net45", ".NET Framework 4.5"),
            new KeyValuePair<string, string>("net451", ".NET Framework 4.5.1"),
            new KeyValuePair<string, string>("net452", ".NET Framework 4.5.2"),
            new KeyValuePair<string, string>("net46", ".NET Framework 4.6"),
            new KeyValuePair<string, string>("net461", ".NET Framework 4.6.1"),
            new KeyValuePair<string, string>("net462", ".NET Framework 4.6.2"),
            new KeyValuePair<string, string>("net47", ".NET Framework 4.7"),
            new KeyValuePair<string, string>("net471", ".NET Framework 4.7.1"),
            new KeyValuePair<string, string>("net472", ".NET Framework 4.7.2"),
            new KeyValuePair<string, string>("netcoreapp1.0", ".NET Core 1.0"),
            new KeyValuePair<string, string>("netcoreapp1.1", ".NET Core 1.1"),
            new KeyValuePair<string, string>("netcoreapp2.0", ".NET Core 2.0"),
            new KeyValuePair<string, string>("netcoreapp2.1", ".NET Core 2.1"),
        };

        private string framework = "netcoreapp2.1";
        public string Framework
        {
            get => framework;
            set
            {
                framework = value;
                OnPropertyChanged();
            }
        }

        private bool enablePack = false;

        public bool EnablePack
        {
            get => enablePack;
            set
            {
                enablePack = value;
                OnPropertyChanged();
            }
        }

        private bool skipRestore = false;
        public bool SkipRestore
        {
            get => skipRestore;
            set
            {
                skipRestore = value;
                OnPropertyChanged();
            }
        }

        private string projectName = "";
        public string ProjectName {
            get => projectName;
            set
            {
                projectName = value;
                OnPropertyChanged();
            }
        }

        private string destinationDirectory = "";
        public string DestinationDirectory
        {
            get => destinationDirectory;
            set
            {
                destinationDirectory = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}