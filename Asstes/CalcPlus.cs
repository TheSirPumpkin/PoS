using UnityEngine;
using System.Collections;

public class CalcPlus : MonoBehaviour {

	public	 CalcExp plus;
	
	public void Plus()
	{
		if(plus.counter<=8)
			plus.counter = plus.counter + 1;
	}
}
