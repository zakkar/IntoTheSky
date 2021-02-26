using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
    [CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/Parameter Events/Object Event")]
    public class ObjectEvent : SimpleEvent
    {
        public object Value;

        public void Raise(object inValue)
        {
            Value = inValue;
            base.Raise();
        }
    }
}