using UnityEngine;
using System.Collections;

public class RentGymPlus : MonoBehaviour {
	
	public RentData RD;
	
	public void increase()
	{
		if (RD.gym <= 1) {
			RD.gym = RD.gym + 1;
		}
		
	}
}
