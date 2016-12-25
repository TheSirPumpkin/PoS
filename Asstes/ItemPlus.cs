using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ItemPlus : MonoBehaviour {
	public RepairCraft rc;
	
	public void increase()
	{

			rc.i = rc.i + 1;

	}

}
