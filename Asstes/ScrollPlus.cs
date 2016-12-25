using UnityEngine;
using System.Collections;

public class ScrollPlus : MonoBehaviour {

	public	ScrollFest plus;
	
	public void Plus()
	{
		if(plus.festival<=3)
			plus.festival = plus.festival + 1;
	}
}
