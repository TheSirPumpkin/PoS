using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class CalcExp : MonoBehaviour {
	public Text txt,txt1;
	public int exp,exp1,exp2,exp3,exp4,exp5,exp6,exp7,exp8,exp9;
	public int counter;
	//public int result;

	public void Shitai()
	{
		if (counter == 0) {
			exp=System.Int32.Parse(txt.text);
		}
		if (counter == 1) {
			exp1=System.Int32.Parse(txt.text);
		}
		if (counter == 2) {
			exp2=System.Int32.Parse(txt.text);
		}
		if (counter == 3) {
			exp3=System.Int32.Parse(txt.text);
		}
		if (counter == 4) {
			exp4=System.Int32.Parse(txt.text);
		}
		if (counter == 5) {
			exp5=System.Int32.Parse(txt.text);
		}
		if (counter == 6) {
			exp6=System.Int32.Parse(txt.text);
		}
		if (counter == 7) {
			exp7=System.Int32.Parse(txt.text);
		}
		if (counter == 8) {
			exp8=System.Int32.Parse(txt.text);
		}
		if (counter == 9) {
			exp9=System.Int32.Parse(txt.text);
		}

	}

}