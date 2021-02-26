using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
    [CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/Parameter Events/Int Event")]
    public class IntEvent : SimpleEvent
    {
        public int Value;

        public void Raise(int inValue)
        {
            Value = inValue;
            base.Raise();
        }
    }
}