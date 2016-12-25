using UnityEngine;
using System.Collections;

public class TrainerAccDown : MonoBehaviour {

	public AssignTrainer rc;
	
	public void decrease()
	{
		if (rc.trainer >= 1) {
			rc.trainer = rc.trainer - 1;
		}
	}
}
