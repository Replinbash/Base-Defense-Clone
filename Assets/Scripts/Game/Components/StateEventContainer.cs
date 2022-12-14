namespace BaseDefense.Component
{
	using UnityEngine;
	using BaseDefense.Base.Component;
	using UnityEngine.Events;

	public class StateEventContainer : IComponent
	{
		public void Initilaze(ComponentContainer componentContainer)
		{
			Debug.Log("<color=green>StateEventContainer initialized!</color>");
		}

		public event UnityAction OnFightStateEvent = delegate { };
		public event UnityAction OnUpgradeStateEvent = delegate { };
		public event UnityAction ReturnUpgradeIdleEvent = delegate { };
		public event UnityAction TurretControlEvent = delegate { };	
		public event UnityAction AmmoCollectEvent = delegate { };
		public event UnityAction AmmoAreaEvent = delegate { };	
		
		public void OnFightState() => OnFightStateEvent?.Invoke();	
		public void OnUpgradeState () => OnUpgradeStateEvent?.Invoke();
		public void TurretControl() => TurretControlEvent?.Invoke();		
		public void ReturnUpgradeIdle() => ReturnUpgradeIdleEvent?.Invoke();	
		public void OnAmmoCollect() => AmmoCollectEvent?.Invoke();
		public void OnAmmoArea() => AmmoAreaEvent?.Invoke();	

	}
}