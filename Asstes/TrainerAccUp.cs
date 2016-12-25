using UnityEngine;
using System.Collections;

public class TrainerAccUp : MonoBehaviour {

	public AssignTrainer rc;
	
	public void increase()
	{
		if (rc.trainer <= 1) {
			rc.trainer = rc.trainer + 1;
		}
		
	}

}
