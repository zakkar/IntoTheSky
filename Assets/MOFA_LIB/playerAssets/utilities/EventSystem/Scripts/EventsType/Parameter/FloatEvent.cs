using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
    [CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/Parameter Events/Float Event")]
    public class FloatEvent : SimpleEvent
    {
        public float Value;

        public void Raise(float inValue)
		{
            Value = inValue;
            base.Raise();
		}
    }

}