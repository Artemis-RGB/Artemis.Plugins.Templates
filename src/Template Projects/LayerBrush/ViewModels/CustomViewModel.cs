using Artemis.Core.Plugins.LayerBrushes;
using Artemis.UI.Shared.Services.Interfaces;
using $safeprojectname$.PropertyGroups;

namespace $safeprojectname$.ViewModels
{
    public class CustomViewModel : BrushConfigurationViewModel
    {
        private readonly IDialogService _dialogService;
        private string _testString;
        private int _testNumber;

        public CustomViewModel(PluginLayerBrush LayerBrush, IDialogService dialogService) : base(LayerBrush)
        {
            Properties = LayerBrush.Properties;

            _dialogService = dialogService;
        }

        public MainPropertyGroup Properties { get; }

        // Regular auto-properties will not update the UI.
        // Because of that you must use SetAndNotify in your ViewModels as shown below
        public string TestString
        {
            get => _testString;
            set => SetAndNotify(ref _testString, value);
        }

        public int TestNumber
        {
            get => _testNumber;
            set => SetAndNotify(ref _testNumber, value);
        }

        // These two methods will be called when we press the buttons in our view
        public void TestPopupAction()
        {
            _dialogService.ShowConfirmDialog("Test popup", $"Looks like you entered: {TestString}");
        }

        public void TestNumberAction()
        {
            TestNumber++;
        }
    }
}