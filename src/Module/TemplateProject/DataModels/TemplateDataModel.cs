using System.Collections.Generic;
using Artemis.Core.Plugins.Abstract.DataModels;
using Artemis.Core.Plugins.Abstract.DataModels.Attributes;

namespace ModuleProject.DataModels
{
    public class TemplateDataModel : DataModel
    {
        public TemplateDataModel()
        {
            TemplateSubDataModel = new TemplateSubDataModel();
        }

        // Your datamodel can have regular properties and you can annotate them if you'd like
        [DataModelProperty(Name = "A test string", Description = "It doesn't do much, but it's there.")]
        public string TemplateDataModelString { get; set; }

        // You can even have classes in your datamodel, just don't forget to instantiate them ;)
        [DataModelProperty(Name = "A class within the datamodel")]
        public TemplateSubDataModel TemplateSubDataModel { get; set; }
    }

    public class TemplateSubDataModel
    {
        public TemplateSubDataModel()
        {
            ListOfInts = new List<int> {1, 2, 3, 4, 5};
        }

        // You don't need to annotate properties, they will still show up 
        public float FloatyFloat { get; set; }

        // You can even have a list!
        public List<int> ListOfInts { get; set; }

        // If you don't want a property to show up in the datamodel, annotate it with DataModelIgnore
        [DataModelIgnore]
        public string MyDarkestSecret { get; set; }
    }
}