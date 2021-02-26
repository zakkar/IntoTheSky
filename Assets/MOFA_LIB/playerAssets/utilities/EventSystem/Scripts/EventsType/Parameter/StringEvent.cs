using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
    [CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/Parameter Events/String Event")]
    public class StringEvent : SimpleEvent
    {
        public string Value;

        public void Raise(string inValue)
        {
            Value = inValue;
            base.Raise();
        }
    }
}