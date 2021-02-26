using MofaLib.Utilities.EventSystem;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
	public class ObjectEventListener : SimpleEventListener
	{
		public ObjectEvent ObjectEvent;

		public OEvent ObjectResponse;

		protected override void OnEnable()
		{
			if (ObjectEvent == null)
			{
				Debug.LogError("Event variable is not set on " + this.name);
				return;
			}

			ObjectEvent.RegisterListener(this);
		}

		protected override void OnDisable()
		{
			if (ObjectEvent == null)
			{
				Debug.LogError("Event variable is not set");
				return;
			}

			ObjectEvent.UnregisterListener(this);
		}

		[ContextMenu("Raise Events")]
		public override void OnEventRaise(SimpleEvent inSimpleEvent)
		{
			if (ObjectResponse.GetPersistentEventCount() > 0)
			{
				ObjectResponse.Invoke(ObjectEvent.Value);
			}
		}

#if UNITY_EDITOR
		protected override void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingPlayMode)
			{
				ObjectEvent.FlushListenerList();
			}
		}
#endif
	}
}

