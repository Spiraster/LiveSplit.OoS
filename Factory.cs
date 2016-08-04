using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;

[assembly: ComponentFactory(typeof(LiveSplit.OoS.OoSFactory))]

namespace LiveSplit.OoS
{
    public class OoSFactory : IComponentFactory
    {
        public string ComponentName => "OoS Auto Splitter";
        public string Description => "Autosplitter for Oracle of Seasons with BGB and Gambatte";
        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public ComponentCategory Category => ComponentCategory.Control;

        public string UpdateName => ComponentName;
        public string UpdateURL => "https://raw.githubusercontent.com/Spiraster/LiveSplit.OoS/master/";
        public string XMLURL => UpdateURL + "Components/update.LiveSplit.OoS.xml";

        public IComponent Create(LiveSplitState state)
        {
            return new OoSComponent(state);
        }
    }
}
