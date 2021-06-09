using System.Diagnostics;
using System.Windows;
using Microsoft.VisualStudio.PlatformUI;

namespace ArtemisPluginTemplates.PluginTypes.Module
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