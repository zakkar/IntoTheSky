using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace MofaLib.Utilities.EventSystem
{
    [CustomEditor(typeof(SimpleEvent))]
    public class SimpleEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            SimpleEvent customEvent = target as SimpleEvent;

            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise();
            }
        }
    }

    [CustomEditor(typeof(ParameterEvent))]
    public class ParameterEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            ParameterEvent paramEvent = target as ParameterEvent;

            if (GUILayout.Button("Raise"))
            {
                paramEvent.Raise();
            }
        }
    }


    [CustomEditor(typeof(StateEvent))]
    public class StateEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            SimpleEvent stateEvent = target as SimpleEvent;

            if (GUILayout.Button("Raise"))
            {
                stateEvent.Raise();
            }
        }
    }

    [CustomEditor(typeof(IntEvent))]
    public class IntegerEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            IntEvent customEvent = target as IntEvent;

            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise();
            }
        }
    }

    [CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            FloatEvent customEvent = target as FloatEvent;

            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise();
            }
        }
    }

    [CustomEditor(typeof(StringEvent))]
    public class StringEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            StringEvent customEvent = target as StringEvent;

            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise();
            }
        }
    }

    [CustomEditor(typeof(BoolEvent))]
    public class BoolEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            BoolEvent customEvent = target as BoolEvent;

            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise();
            }
        }
    }

    [CustomEditor(typeof(ObjectEvent))]
    public class ObjectEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            ObjectEvent customEvent = target as ObjectEvent;

            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise();
            }
        }
    }
}