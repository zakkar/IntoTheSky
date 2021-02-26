using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MofaLib.Utilities.EventSystem
{
	public interface IEventListener
	{
		 void OnEventRaise(SimpleEvent inSimpleEvent);
	}
}
