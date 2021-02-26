using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace MofaLib.Utilities.EventSystem
{
	public class SimpleEventListener : MonoBehaviour, IEventListener
	{
		[HideInInspector]
		public SimpleEvent SimpleEvent;

		[HideInInspector]
		public UnityEvent Response;

		protected virtual void OnEnable()
		{
			if (SimpleEvent == null)
			{
				Debug.LogError("Event variable is not set on " + this.name);
				return;
			}

			SimpleEvent.RegisterListener(this);
		}

		protected virtual void OnDisable()
		{
			if (SimpleEvent == null)
			{
				Debug.LogError("Event variable is not set on "+ this.name);
				return;
			}

			SimpleEvent.UnregisterListener(this);
		}

		[ContextMenu("Raise Events")]
		public virtual void OnEventRaise(SimpleEvent inSimpleEvent)
		{
			if(Response.GetPersistentEventCount() > 0)
			{
				Response.Invoke();
			}
		}

#if UNITY_EDITOR
		protected virtual void OnPlayModeStateChanged(PlayModeStateChange state)
		{
			if (state == PlayModeStateChange.ExitingPlayMode)
			{
				SimpleEvent.FlushListenerList();
			}
		}
#endif
	}
}

