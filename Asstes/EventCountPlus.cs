using UnityEngine;
using System.Collections;

public class EventCountPlus : MonoBehaviour {

	public EventCounter rc;
	
	public void increase()
	{
		if(rc.count<=3)
		rc.count = rc.count + 1;
		
	}
}
