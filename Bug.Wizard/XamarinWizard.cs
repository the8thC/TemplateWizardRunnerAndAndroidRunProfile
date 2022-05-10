using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TemplateWizard;

namespace Bug.Wizard {
    public class BugWizard : IWizard {

        object AutomationObject { get; set; }

        
        public void BeforeOpeningFile(global::EnvDTE.ProjectItem projectItem) {
        }

        public void ProjectFinishedGenerating(global::EnvDTE.Project project) {
        }

        public void ProjectItemFinishedGenerating(global::EnvDTE.ProjectItem projectItem) {
        }
        
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams) {
            replacementsDictionary.Add("$uistyle$", "none");
            replacementsDictionary.Add("$language$", "CSharp");
            replacementsDictionary.Add("$templateid$", "bug.some.one");
        }
        
        public void RunFinished() {
        }

        public bool ShouldAddProjectItem(string filePath) {
            return true;
        }        
    }
}
