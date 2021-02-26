using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEvents;

namespace MofaLib.Utilities.EventSystem
{
    [System.Serializable]
    public struct EventParams
    {
        public EventParams(int inInt = -1, float inFloat = -1f, bool inBool = false, string inString = "", object inObj = null)
        {
            IntParam = inInt;
            FloatParam = inFloat;
            BoolParam = inBool;
            StringParam = inString;
            ObjectParam = inObj;
        }

        public int IntParam;
        public float FloatParam;
        public bool BoolParam;
        public string StringParam;
        public object ObjectParam;
    }

    [System.Serializable]
    public class EventAndResponse
    {
        public ParameterEvent ParamEvent;

        // Single parameter events 
        public IEvent responseUsingInt;
        public FEvent responseUsingFloat;
        public BEvent responseUsingBool;
        public SEvent responseUsingString;
        public OEvent responseUsingObject;

        public void Raise()
        {
            EventParams eventParams = ParamEvent.Parameters;

            // string
            if (responseUsingString.GetPersistentEventCount() >= 1)
            {
                responseUsingString.Invoke(eventParams.StringParam);
            }

            // int
            if (responseUsingInt.GetPersistentEventCount() >= 1)
            {
                responseUsingInt.Invoke(eventParams.IntParam);
            }

            // float
            if (responseUsingFloat.GetPersistentEventCount() >= 1)
            {
                responseUsingFloat.Invoke(eventParams.FloatParam);
            }

            // bool
            if (responseUsingBool.GetPersistentEventCount() >= 1)
            {
                responseUsingBool.Invoke(eventParams.BoolParam);
            }

            // obj
            if (responseUsingObject.GetPersistentEventCount() >= 1)
            {
                responseUsingObject.Invoke(eventParams.ObjectParam);
            }
        }
    }

    public enum EventPhase
    {
        Start,
        Update,
        End
    }
}