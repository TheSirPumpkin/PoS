using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class AddExp : MonoBehaviour {
	public CalcExp calc; 
	public int result;
	public Text txt;
	public void krrwa()
	{
		result = calc.exp + calc.exp1 + calc.exp2 + calc.exp3 + calc.exp4 + calc.exp5 + calc.exp6 + calc.exp7 + calc.exp8 + calc.exp9;
		txt.text = "" + result;
	}
}
