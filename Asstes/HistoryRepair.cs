using UnityEngine;
using System.Collections;

public class HistoryRepair : MonoBehaviour {
	public bool Repair;
	public HistoryCraft craft;
	public void IsActiv()
	{
		Repair = true;
		craft.Craft = false;
		
		
	}
}
