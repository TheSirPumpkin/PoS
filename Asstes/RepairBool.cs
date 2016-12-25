using UnityEngine;
using System.Collections;

public class RepairBool : MonoBehaviour {
	public CraftBool craft;
	public bool Repair;
	public void IsActive()
	{
		Repair = true;
		craft.Craft = false;

	}

}
