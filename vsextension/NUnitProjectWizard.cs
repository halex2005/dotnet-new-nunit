using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;

namespace NUnitTemplatesVsix
{
    class NUnitProjectWizard : IWizard
    {
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            //TODO: redefine root namespace from automationObject!
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
            dialog.ShowModal();
            if (templateOptions.UserCanceledTemplateCreation)
            {
                throw new WizardCancelledException("user cancelled template creation");
            }
            //TODO: create project with filled options
            //replacementsDictionary.Add("$platformversion$", dialog.TemplateOptions.Framework);
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
