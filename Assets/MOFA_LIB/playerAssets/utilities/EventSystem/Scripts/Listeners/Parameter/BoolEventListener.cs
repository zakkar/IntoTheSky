using MofaLib.Utilities.EventSystem;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
	public class BoolEventListener : SimpleEventListener
	{
		public BoolEvent BoolEvent;

		public BEvent BoolResponse;

		protected override void OnEnable()
		{
			if (BoolEvent == null)
			{
				Debug.LogError("Event variable is not set on " + this.name);
				return;
			}

			BoolEvent.RegisterListener(this);
		}

		protected override void OnDisable()
		{
			if (BoolEvent == null)
			{
				Debug.LogError("Event variable is not set");
				return;
			}

			BoolEvent.UnregisterListener(this);
		}

		[ContextMenu("Raise Events")]
		public override void OnEventRaise(SimpleEvent inSimpleEvent)
		{
			if (BoolResponse.GetPersistentEventCount() > 0)
			{
				BoolResponse.Invoke(BoolEvent.Value);
			}
		}

#if UNITY_EDITOR
		protected override void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingPlayMode)
			{
				BoolEvent.FlushListenerList();
			}
		}
#endif
	}
}

