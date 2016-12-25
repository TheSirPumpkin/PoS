using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class CalcCounter : MonoBehaviour {
	public	 CalcExp show;
	public Text txt;

	public void DaiteTri()
	{
		txt.text = "" + show.counter;
	}
}
