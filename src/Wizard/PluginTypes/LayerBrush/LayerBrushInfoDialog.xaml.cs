using System.Diagnostics;
using System.Windows;
using Microsoft.VisualStudio.PlatformUI;

namespace PluginTemplatesWizard.PluginTypes.LayerBrush
{
    /// <summary>
    ///     Interaction logic for LayerBrushInfoDialog.xaml
    /// </summary>
    public partial class LayerBrushInfoDialog : DialogWindow
    {
        private readonly LayerBrushInfo _layerBrushInfo;

        internal LayerBrushInfoDialog(LayerBrushInfo layerBrushInfo)
        {
            _layerBrushInfo = layerBrushInfo;
            InitializeComponent();

            NameTextBox.Text = _layerBrushInfo.Name;
            IconTextBox.Text = _layerBrushInfo.Icon;
            DescriptionTextBox.Text = _layerBrushInfo.Description;

            if (_layerBrushInfo.RenderType == "Regular")
                RenderTypeRegular.IsChecked = true;
            else if (_layerBrushInfo.RenderType == "PerLed")
                RenderTypePerLed.IsChecked = true;
            else if (_layerBrushInfo.RenderType == "RgbNet")
                RenderTypeRgbNet.IsChecked = true;

            IncludeDialogCheckBox.IsChecked = _layerBrushInfo.IncludeCustomDialog;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            // Cant be bothered with nice validation right now
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(IconTextBox.Text))
                return;

            _layerBrushInfo.Name = NameTextBox.Text;
            _layerBrushInfo.Icon = IconTextBox.Text;
            _layerBrushInfo.Description = DescriptionTextBox.Text;

            if (RenderTypeRegular.IsChecked == true)
                _layerBrushInfo.RenderType = "Regular";
            else if (RenderTypePerLed.IsChecked == true)
                _layerBrushInfo.RenderType = "PerLed";
            else if (RenderTypeRgbNet.IsChecked == true)
                _layerBrushInfo.RenderType = "RgbNet";
            
            _layerBrushInfo.IncludeCustomDialog = IncludeDialogCheckBox.IsChecked == true;

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