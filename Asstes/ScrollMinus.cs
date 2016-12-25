using UnityEngine;
using System.Collections;

public class ScrollMinus : MonoBehaviour {

	public	ScrollFest minus;
	
	public void Minus()
	{
		if(minus.festival>=1)
			minus.festival = minus.festival - 1;
	}
}
