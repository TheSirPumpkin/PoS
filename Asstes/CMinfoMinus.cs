using UnityEngine;
using System.Collections;

public class CMinfoMinus : MonoBehaviour {

	public CMinfoData CM;
	
	public void decrease()
	{
		if (CM.member >= 1) {
			CM.member = CM.member - 1;
		}
	}
}
