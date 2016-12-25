using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;


public class RepairCraft : MonoBehaviour {

	// RepairBool repair;
	//public CraftBool craft;
	public Text txt;

	public int i;

	public void Func()
	{
		txt.text = "amount"+" "+i;
	}

}
