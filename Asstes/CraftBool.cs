using UnityEngine;
using System.Collections;

public class CraftBool : MonoBehaviour {
	public bool Craft;
	public RepairBool repair;
	public void IsActiv()
	{
		Craft = true;
		repair.Repair = false;

	}


}
