﻿using System;

namespace DLaB.VSSolutionAccelerator
{
    public abstract class SolutionEditorInfo
    {
        public string SolutionPath { get; set; }
        public bool CreatePlugin { get; set; }
        public bool IncludeExamplePlugins { get; set; }
        public bool CreateWorkflow { get; set; }
        public bool IncludeExampleWorkflow { get; set; }
        public string PluginName { get; set; }
        public string WorkflowName { get; set; }
        public string PluginTestName { get; set; }
        public string WorkflowTestName { get; set; }
        public string SharedCommonProject { get; set; }
        public string SharedCommonWorkflowProject { get; set; }
        public string TestBaseProject { get; set; }
        public string SharedTestCoreProject { get; set; }
        public virtual Version XrmVersion { get; set; }

        public string GetPluginAssemblyVersionForSdk()
        {
            return XrmVersion.Major >= 9 ? "v4.6.2" : "v4.5.2";
        }
    }
}
