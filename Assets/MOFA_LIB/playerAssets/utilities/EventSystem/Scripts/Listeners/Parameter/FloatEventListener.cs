using MofaLib.Utilities.EventSystem;
using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
	public class FloatEventListener : SimpleEventListener
	{
		public FloatEvent FloatEvent;

		public FEvent FloatResponse;

		protected override void OnEnable()
		{
			if (FloatEvent == null)
			{
				Debug.LogError("Event variable is not set on " + this.name);
				return;
			}

			FloatEvent.RegisterListener(this);
		}

		protected override void OnDisable()
		{
			if (FloatEvent == null)
			{
				Debug.LogError("Event variable is not set");
				return;
			}

			FloatEvent.UnregisterListener(this);
		}

		[ContextMenu("Raise Events")]
		public override void OnEventRaise(SimpleEvent inSimpleEvent)
		{
			if (FloatResponse.GetPersistentEventCount() > 0)
			{
				FloatResponse.Invoke(FloatEvent.Value);
			}
		}

#if UNITY_EDITOR
		protected override void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingPlayMode)
			{
				FloatEvent.FlushListenerList();
			}
		}
#endif
	}
}

