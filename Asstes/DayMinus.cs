using UnityEngine;
using System.Collections;

public class DayMinus : MonoBehaviour {

	public DaysData DD;
	
	public void decrease()
	{
		if (DD.day  >= 1) {
			DD.day  = DD.day  - 1;
		}
	}
}
