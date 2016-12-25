using UnityEngine;
using System.Collections;

public class RoleMinus : MonoBehaviour {

	public RoleData CM;
	
	public void decrease()
	{
		if (CM.role >= 1) {
			CM.role = CM.role - 1;
		}
	}
}
