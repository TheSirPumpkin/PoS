using UnityEngine;
using System.Collections;

public class HistoryCraft : MonoBehaviour {
	public bool Craft;
	public HistoryRepair repair;
	public void IsActiv()
	{
		Craft = true;
		repair.Repair = false;
		
		
	}
}
