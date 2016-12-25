using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class MemberCount : MonoBehaviour {
	public int bulo=5;
	public int count;
	public Text text;

	public void Calculate()
	{
		int stalo = bulo + count;
		text.text = "There are" + stalo+" "+ " club members";
	}
}
