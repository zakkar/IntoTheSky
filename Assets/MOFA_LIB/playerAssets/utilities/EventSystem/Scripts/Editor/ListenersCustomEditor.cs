using UnityEngine;
using UnityEditor;

namespace MofaLib.Utilities.EventSystem
{
    [CustomEditor(typeof(SimpleEventListener))]
    public class GameListenersCustomization : Editor
    {
        private SerializedProperty simpleEvent;
        private SerializedProperty response;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            SimpleEventListener eventListener = target as SimpleEventListener;
            if (eventListener == null)
            {
                return;
            }

            simpleEvent = serializedObject.FindProperty("SimpleEvent");
            simpleEvent.objectReferenceValue = EditorGUILayout.ObjectField("Event", simpleEvent.objectReferenceValue, typeof(SimpleEvent), false);

            // Find the property corresponding to the UnityEvent we want to edit.
            response = serializedObject.FindProperty("Response");

            // Draw the Inspector widget for this property.
            EditorGUILayout.PropertyField(response, new GUIContent("Response"), true);

            // Commit changes to the property back to the component we're editing.
            serializedObject.ApplyModifiedProperties();
        }
    }


    [CustomEditor(typeof(StateEventListener))]
    public class StateListenersCustomization : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            StateEventListener stateListener = target as StateEventListener;

            if (stateListener == null)
            {
                return;
            }


            stateListener.EventCollection = (StateEventCollection)EditorGUILayout.ObjectField("Event Collection", stateListener.EventCollection, typeof(StateEventCollection), true);

            SerializedProperty eventPhase = serializedObject.FindProperty("EventPhase");

            // Draw the Inspector widget for this property.
            EditorGUILayout.PropertyField(eventPhase, new GUIContent("Event Phase"), true);

            // Commit changes to the property back to the component we're editing.
            serializedObject.ApplyModifiedProperties();

            // Find the property corresponding to the UnityEvent we want to edit.
            SerializedProperty response = serializedObject.FindProperty("Response");

            // Draw the Inspector widget for this property.
            EditorGUILayout.PropertyField(response, new GUIContent("Response"), true);

            // Commit changes to the property back to the component we're editing.
            serializedObject.ApplyModifiedProperties();
        }
    }
}