using System;
using UnityEngine;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
	[CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/Parameter Events/Parameter Event")]
	public class ParameterEvent : SimpleEvent
	{
		public EventParams Parameters;

        public void Raise(int intVal = 0, float floatVal = 0, bool boolVal = false, string stringVal = "", object objVal = null)
        {
            Parameters.IntParam = intVal;
            Parameters.FloatParam = floatVal;
            Parameters.BoolParam = boolVal;
            Parameters.StringParam = stringVal;
            Parameters.ObjectParam = objVal;
            base.Raise();
        }
    }
}
