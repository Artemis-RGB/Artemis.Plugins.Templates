namespace ModuleProjectWizard.Models
{
    internal class ModuleInfo
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string PriorityCategory { get; set; }
        public bool EnableProfiles { get; set; }
        public bool EnableDataModel { get; set; }
        public bool IncludeCustomTab { get; set; }
    }
}