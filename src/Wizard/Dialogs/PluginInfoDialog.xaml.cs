using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using ArtemisPluginTemplates.Models;
using Microsoft.VisualStudio.PlatformUI;

namespace ArtemisPluginTemplates.Dialogs
{
    /// <summary>
    ///     Interaction logic for WizardDialog.xaml
    /// </summary>
    public partial class PluginInfoDialog : DialogWindow
    {
        private readonly PluginInfo _pluginInfo;

        internal PluginInfoDialog(PluginInfo pluginInfo)
        {
            _pluginInfo = pluginInfo;
            InitializeComponent();

            NameTextBox.Text = _pluginInfo.Name;
            DescriptionTextBox.Text = _pluginInfo.Description;
            IconTextBox.Text = _pluginInfo.Icon;
            AuthorTextBox.Text = _pluginInfo.Author;
            WebsiteTextBox.Text = _pluginInfo.Website?.ToString();
            RepositoryTextBox.Text = _pluginInfo.Repository?.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            // Cant be bothered with nice validation right now
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
                return;

            // Ensure the selected path points to an existing Artemis executable
            if (!File.Exists(ArtemisExecutableTextBox.Text))
            {
                MessageBox.Show(
                    $"Artemis executable not found at \r\n{ArtemisExecutableTextBox.Text}",
                    "Artemis executable not found",
                    MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }

            // Ensure the Artemis.Core.dll and Artemis.UI.Shared.dll are in the same directory
            var artemisDirectory = Path.GetDirectoryName(ArtemisExecutableTextBox.Text);
            if (!File.Exists(Path.Combine(artemisDirectory, "Artemis.Core.dll")))
            {
                MessageBox.Show(
                    $"Artemis Core library not found in \r\n{artemisDirectory}",
                    "Artemis executable not found",
                    MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }

            if (!File.Exists(Path.Combine(artemisDirectory, "Artemis.UI.Shared.dll")))
            {
                MessageBox.Show(
                    $"Artemis Shared UI library found in \r\n{artemisDirectory}",
                    "Artemis executable not found",
                    MessageBoxButton.OK,
                    MessageBoxImage.Exclamation);
                return;
            }

            _pluginInfo.ArtemisDirectory = artemisDirectory;
            _pluginInfo.Name = NameTextBox.Text;
            _pluginInfo.Description = DescriptionTextBox.Text;
            _pluginInfo.Icon = IconTextBox.Text;
            _pluginInfo.Author = AuthorTextBox.Text;

            try
            {
                _pluginInfo.Website = !string.IsNullOrWhiteSpace(WebsiteTextBox.Text)
                    ? new Uri(WebsiteTextBox.Text, UriKind.Absolute)
                    : null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Failed to parse website URL", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            try
            {
                _pluginInfo.Repository = !string.IsNullOrWhiteSpace(RepositoryTextBox.Text)
                    ? new Uri(RepositoryTextBox.Text, UriKind.Absolute)
                    : null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Failed to parse repository URL", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }

            DialogResult = true;
            Close();
        }

        private void BrowseDirectoryButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dlg = new Microsoft.Win32.OpenFileDialog
            {
                FileName = "Artemis.UI",
                DefaultExt = ".exe",
                Filter = "Artemis.UI (*.exe)|*.exe|All Files (*.*)|*.*"
            };

            var result = dlg.ShowDialog();
            if (result == true)
                ArtemisExecutableTextBox.Text = dlg.FileName;
        }

        private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start("https://materialdesignicons.com/");
        }
    }
}