using UnityEngine;

namespace MofaLib.Utilities.EventSystem
{
    [CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/State Collection Event")]
    public class StateEventCollection : ScriptableObject
    {
        public string CollectionName;
        public StateEvent[] StateEvents;
    }
}
