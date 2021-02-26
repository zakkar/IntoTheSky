using UnityEngine;

namespace MofaLib.Utilities.EventSystem
{
	public class StateEventListener : SimpleEventListener
	{
		[HideInInspector]
		public StateEventCollection EventCollection;

		[HideInInspector]
		public EventPhase EventPhase;

		protected override void OnEnable()
		{
			if (EventCollection.StateEvents.Length == 0)
			{
				Debug.LogError("Event variable is not set on " + this.name);
				return;
			}

			foreach (StateEvent ev in EventCollection.StateEvents)
			{
				if (ev.StatePhase == EventPhase)
				{
					ev.RegisterListener(this);
					SimpleEvent = ev;
					break;
				}
			}
		}
	}
}

