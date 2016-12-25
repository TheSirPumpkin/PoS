using UnityEngine;
using System.Collections;

public class CMinfoPlus : MonoBehaviour {

	public CMinfoData CM;
	
	public void plus()
	{
		if(CM.member<=3)
			CM.member = CM.member + 1;

	}
}
