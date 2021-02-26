using MofaLib.Utilities.EventSystem;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
	public class StringEventListener : SimpleEventListener
	{
		public StringEvent StringEvent;

		public SEvent StringResponse;

		protected override void OnEnable()
		{
			if (StringEvent == null)
			{
				Debug.LogError("Event variable is not set on " + this.name);
				return;
			}

			StringEvent.RegisterListener(this);
		}

		protected override void OnDisable()
		{
			if (StringEvent == null)
			{
				Debug.LogError("Event variable is not set");
				return;
			}

			StringEvent.UnregisterListener(this);
		}

		[ContextMenu("Raise Events")]
		public override void OnEventRaise(SimpleEvent inSimpleEvent)
		{
			if (StringResponse.GetPersistentEventCount() > 0)
			{
				StringResponse.Invoke(StringEvent.Value);
			}
		}

#if UNITY_EDITOR
		protected override void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingPlayMode)
			{
				StringEvent.FlushListenerList();
			}
		}
#endif
	}
}

