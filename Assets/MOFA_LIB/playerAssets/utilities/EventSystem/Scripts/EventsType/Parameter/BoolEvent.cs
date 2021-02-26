using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
    [CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/Parameter Events/Bool Event")]
    public class BoolEvent : SimpleEvent
    {
        public bool Value;

        public void Raise(bool inValue)
        {
            Value = inValue;
            base.Raise();
        }
    }
}