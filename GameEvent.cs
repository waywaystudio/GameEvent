using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Wayway.Engine.Events.Core;

namespace Wayway.Engine.Events
{
    public class GameEvent : GameEventCore
    {
        public List<GameEventListener> EventListenerList 
            => ListenerList.Cast<GameEventListener>().ToList();

        public void Invoke() => EventListenerList.ForEach(x => x.Invoke());
    }
}
