using UnityEngine;
using System.Collections;

public class EventCountMinus : MonoBehaviour {

	public EventCounter rc;
	
	public void decrease()
	{
		if (rc.count >= 1) {
			rc.count = rc.count - 1;
		}
	}
}
