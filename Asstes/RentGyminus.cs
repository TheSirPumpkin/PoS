using UnityEngine;
using System.Collections;

public class RentGyminus : MonoBehaviour {

	public RentData RD;
	
	public void decrease()
	{
		if (RD.gym  >= 1) {
			RD.gym  = RD.gym  - 1;
		}
	}
}
