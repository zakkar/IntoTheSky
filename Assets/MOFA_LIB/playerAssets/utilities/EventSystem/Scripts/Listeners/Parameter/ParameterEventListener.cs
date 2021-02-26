using System.Collections.Generic;
using UnityEditor;

namespace MofaLib.Utilities.EventSystem
{
	public class ParameterEventListener : SimpleEventListener
	{
		public List<EventAndResponse> EventResponse;
		protected override void OnEnable()
		{
			if (EventResponse.Count >= 1)
			{
				foreach (EventAndResponse eAndR in EventResponse)
				{
					if (eAndR != null)
					{
						eAndR.ParamEvent.RegisterListener(this);
					}
				}
			}
		}

		protected override void OnDisable()
		{
			if (EventResponse.Count >= 1)
			{
				foreach (EventAndResponse eAndR in EventResponse)
				{
					if (eAndR != null)
					{
						eAndR.ParamEvent.UnregisterListener(this);
					}
				}
			}
		}

		public override void OnEventRaise(SimpleEvent inGameEvent)
		{
			foreach (EventAndResponse eAndR in EventResponse)
			{
				if (eAndR.ParamEvent == inGameEvent)
				{
					eAndR.Raise();
				}
			}
		}

#if UNITY_EDITOR
		protected override void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingPlayMode)
			{
				SimpleEvent.FlushListenerList();
			}
		}
#endif
	}
}

