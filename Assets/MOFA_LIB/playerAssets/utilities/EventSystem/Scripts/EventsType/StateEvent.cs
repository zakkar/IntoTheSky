using UnityEngine;


namespace MofaLib.Utilities.EventSystem
{
	[CreateAssetMenu(menuName = "MofaLib/Utilities/Event System/State Event")]
	public class StateEvent : SimpleEvent
	{
		public EventPhase StatePhase;
	}
}
