using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ItemMinus : MonoBehaviour {
	public RepairCraft rc;

	public void decrease()
	{
		if (rc.i >= 1) {
			rc.i = rc.i - 1;
		}
	}

}
