using UnityEngine;
using System.Collections;

public class CalcMinus : MonoBehaviour {

	public	CalcExp minus;
	
	public void Minus()
	{
		if(minus.counter>=1)
			minus.counter = minus.counter - 1;
	}
}
