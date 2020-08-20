using System.Diagnostics;
using System.Windows;
using Microsoft.VisualStudio.PlatformUI;
using ModuleProjectWizard.Models;

namespace ModuleProjectWizard.Dialogs
{
    /// <summary>
    ///     Interaction logic for WizardDialog.xaml
    /// </summary>
    public partial class ModuleInfoDialog : DialogWindow
    {
        private readonly ModuleInfo _moduleInfo;

        internal ModuleInfoDialog(ModuleInfo moduleInfo)
        {
            _moduleInfo = moduleInfo;
            InitializeComponent();

            NameTextBox.Text = _moduleInfo.Name;
            IconTextBox.Text = _moduleInfo.Icon;

            if (_moduleInfo.PriorityCategory == "Normal")
                CategoryNormal.IsChecked = true;
            else if (_moduleInfo.PriorityCategory == "Application")
                CategoryApplication.IsChecked = true;
            else if (_moduleInfo.PriorityCategory == "Overlay")
                CategoryOverlay.IsChecked = true;
            
            EnableProfilesCheckBox.IsChecked = _moduleInfo.EnableProfiles;
            EnableDataModelCheckBox.IsChecked = _moduleInfo.EnableDataModel;
            AddCustomTabCheckBox.IsChecked = _moduleInfo.IncludeCustomTab;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            // Cant be bothered with nice validation right now
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(IconTextBox.Text))
                return;

            _moduleInfo.Name = NameTextBox.Text;
            _moduleInfo.Icon = IconTextBox.Text;

            if (CategoryNormal.IsChecked == true)
                _moduleInfo.PriorityCategory = "Normal";
            else if (CategoryApplication.IsChecked == true)
                _moduleInfo.PriorityCategory = "Application";
            else if (CategoryOverlay.IsChecked == true)
                _moduleInfo.PriorityCategory = "Overlay";

            _moduleInfo.EnableProfiles = EnableProfilesCheckBox.IsChecked == true;
            _moduleInfo.EnableDataModel = EnableDataModelCheckBox.IsChecked == true;
            _moduleInfo.IncludeCustomTab = AddCustomTabCheckBox.IsChecked == true;

            DialogResult = true;
            Close();
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://materialdesignicons.com/");
        }
    }
}