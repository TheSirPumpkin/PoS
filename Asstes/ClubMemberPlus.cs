using UnityEngine;
using System.Collections;

public class ClubMemberPlus : MonoBehaviour {

	public ClubMemberData CM;
	
	public void decrease()
	{
		if (CM.member <= 3) {
			CM.member = CM.member + 1;
		}
	}
}
