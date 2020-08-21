using System.Diagnostics;
using System.Windows;
using Microsoft.VisualStudio.PlatformUI;

namespace PluginTemplatesWizard.PluginTypes.LayerEffect
{
    /// <summary>
    ///     Interaction logic for LayerEffectInfoDialog.xaml
    /// </summary>
    public partial class LayerEffectInfoDialog : DialogWindow
    {
        private readonly LayerEffectInfo _layerEffectInfo;

        internal LayerEffectInfoDialog(LayerEffectInfo layerEffectInfo)
        {
            _layerEffectInfo = layerEffectInfo;
            InitializeComponent();

            NameTextBox.Text = _layerEffectInfo.Name;
            IconTextBox.Text = _layerEffectInfo.Icon;
            DescriptionTextBox.Text = _layerEffectInfo.Description;

            IncludeDialogCheckBox.IsChecked = _layerEffectInfo.IncludeCustomDialog;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            // Cant be bothered with nice validation right now
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(IconTextBox.Text))
                return;

            _layerEffectInfo.Name = NameTextBox.Text;
            _layerEffectInfo.Icon = IconTextBox.Text;
            _layerEffectInfo.Description = DescriptionTextBox.Text;

            _layerEffectInfo.IncludeCustomDialog = IncludeDialogCheckBox.IsChecked == true;

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