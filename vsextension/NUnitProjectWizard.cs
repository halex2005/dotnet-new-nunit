using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace NUnitTemplatesVsix
{
    static class StringExtensions
    {
        public static string NullIfEmpty(this string source)
        {
            return string.IsNullOrEmpty(source)
                ? null
                : source;
        }
    }
    class NUnitProjectWizard : IWizard
    {
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            //$destinationdirectory$
            //$solutiondirectory$
            //$projectname$
            //$safeprojectname$
            //$platformversion$
            var templateOptions = new TemplateOptionsViewModel
            {
                ProjectName = replacementsDictionary["$projectname$"],
                Framework = replacementsDictionary["$platformversion$"].NullIfEmpty() ?? "netcoreapp2.1",
                DestinationDirectory = replacementsDictionary["$destinationdirectory$"]
            };
            var dialog = new TemplateOptionsDialog(templateOptions);
            if (dialog.ShowModal() == true)
            {
                //TODO: create project with filled options
                //replacementsDictionary.Add("$platformversion$", dialog.TemplateOptions.Framework);
            }
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return false;
        }

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }
    }
}
