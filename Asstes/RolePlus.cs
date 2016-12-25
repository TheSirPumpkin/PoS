using UnityEngine;
using System.Collections;

public class RolePlus : MonoBehaviour {

	public RoleData CM;
	
	public void decrease()
	{
		if (CM.role <= 3) {
			CM.role = CM.role + 1;
		}
	}
}
