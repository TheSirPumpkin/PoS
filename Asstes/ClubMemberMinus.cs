using UnityEngine;
using System.Collections;

public class ClubMemberMinus : MonoBehaviour {

	public ClubMemberData CM;
	
	public void decrease()
	{
		if (CM.member >= 1) {
			CM.member = CM.member - 1;
		}
	}
}
