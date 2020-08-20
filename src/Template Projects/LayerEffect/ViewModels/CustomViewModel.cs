﻿using Artemis.Core.Plugins.Abstract.ViewModels;
using Artemis.UI.Shared.Services.Interfaces;
using LayerEffect.PropertyGroups;


// namespace $safeprojectname$.ViewModels
namespace LayerEffect.ViewModels
{
    public class CustomViewModel : EffectConfigurationViewModel
    {
        private readonly IDialogService _dialogService;
        private string _testString;
        private int _testNumber;

        public CustomViewModel(PluginLayerEffect layerEffect, IDialogService dialogService) : base(layerEffect)
        {
            _dialogService = dialogService;
            Properties = layerEffect.Properties;
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