using UnityEngine;
using System.Collections;

public class DayPlus : MonoBehaviour {

	public DaysData DD;
	
	public void increase()
	{
		if (DD.day <= 6) {
			DD.day = DD.day + 1;
		}
		
	}
}
