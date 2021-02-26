
using System;
using System.Collections.Generic;
using UnityEngine;

namespace MofaLib.Utilities.EventSystem
{
	[CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/Simple Event")]
	public class SimpleEvent : ScriptableObject
	{
		private List<IEventListener> listeners = new List<IEventListener>();

		public List<IEventListener> Listeners { get { return listeners; } }

		public virtual void Raise()
		{
			for (int i = listeners.Count - 1; i >= 0; i--)
			{
				listeners[i].OnEventRaise(this);
			}
		}

		public void RegisterRuntimeListener(IEventListener listener)
		{
			listeners.Add(listener);
			Debug.Log("Runtime ListenerAdded! ");
		}

		public virtual void RegisterListener(IEventListener listener)
		{
			listeners.Add(listener);
			Debug.Log("ListenerAdded! ");
		}

		public virtual void UnregisterListener(IEventListener listener)
		{
			listeners.Remove(listener);
		}

		public virtual void FlushListenerList()
		{
			listeners.Clear();
		}
	}
}