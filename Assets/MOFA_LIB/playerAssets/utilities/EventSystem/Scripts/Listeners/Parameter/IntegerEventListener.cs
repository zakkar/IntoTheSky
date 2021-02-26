using MofaLib.Utilities.EventSystem;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
	public class IntegerEventListener : SimpleEventListener
	{
		public IntEvent IntEvent;

		public IEvent IntResponse;

		protected override void OnEnable()
		{
			if (IntEvent == null)
			{
				Debug.LogError("Event variable is not set on " + this.name);
				return;
			}

			IntEvent.RegisterListener(this);
		}

		protected override void OnDisable()
		{
			if (IntEvent == null)
			{
				Debug.LogError("Event variable is not set");
				return;
			}

			IntEvent.UnregisterListener(this);
		}

		[ContextMenu("Raise Events")]
		public override void OnEventRaise(SimpleEvent inSimpleEvent)
		{
			if (IntResponse.GetPersistentEventCount() > 0)
			{
				IntResponse.Invoke(IntEvent.Value);
			}
		}

#if UNITY_EDITOR
		protected override void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingPlayMode)
			{
				IntEvent.FlushListenerList();
			}
		}
#endif
	}
}

