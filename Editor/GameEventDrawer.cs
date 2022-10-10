#if UNITY_EDITOR && ODIN_INSPECTOR
using System;
using System.Collections.Generic;
using System.Reflection;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Wayway.Engine.Events.Core;

namespace Wayway.Engine.Events.Editor
{
    public class GameEventDrawer : OdinAttributeProcessor<GameEventCore>
    {
        public override void ProcessChildMemberAttributes(InspectorProperty parentProperty, MemberInfo member, List<Attribute> attributes)
        {
            switch (member.Name)
            {
                case "subscriberList":
                    attributes.Add(new ReadOnlyAttribute());
                    break;
                case "ShowListener":
                    attributes.Add(new ButtonAttribute(ButtonSizes.Medium));
                    break;
            }
        }
    }
    
    public class GameEventDrawer<T, F> : OdinAttributeProcessor<T> where T : GameEvent<F>
    {
        public override void ProcessChildMemberAttributes(InspectorProperty parentProperty, MemberInfo member, List<Attribute> attributes)
        {
            switch (member.Name)
            {
                case "subscriberList":
                    attributes.Add(new ReadOnlyAttribute());
                    break;
                case "ShowListener":
                    attributes.Add(new ButtonAttribute(ButtonSizes.Medium));
                    break;
            }
        }
    }
    
    public class GameEventDrawer<T, F0, F1> : OdinAttributeProcessor<T> where T : GameEvent<F0, F1>
    {
        public override void ProcessChildMemberAttributes(InspectorProperty parentProperty, MemberInfo member, List<Attribute> attributes)
        {
            switch (member.Name)
            {
                case "subscriberList":
                    attributes.Add(new ReadOnlyAttribute());
                    break;
                case "ShowListener":
                    attributes.Add(new ButtonAttribute(ButtonSizes.Medium));
                    break;
            }
        }
    }

    public class GameEventListenerDrawer : OdinAttributeProcessor<GameEventListenerCore>
    {
        public override void ProcessChildMemberAttributes(InspectorProperty parentProperty, MemberInfo member, List<Attribute> attributes)
        {
            if (member.Name == "priority")
            {
                attributes.Add(new PropertyRangeAttribute(0, 10));
                attributes.Add(new HideLabelAttribute());
            }
        }
    }   
}
#endif


