using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;


public class SaveEQHistory : MonoBehaviour {

	public CraftBool craft;
	public RepairBool repair;
	public RepairCraft RC;
	public Text txt;
	public Text txt2;

	public double cost;

	public void Save()
	{
		if (craft.Craft) 
		{
			StreamWriter sw = new StreamWriter ("database/CraftHistory.txt");
			
			sw.WriteLine (txt.text); 
			sw.WriteLine (txt2.text);
			sw.WriteLine (cost);
		
			sw.Close (); 
			cost = RC.i+1*2;
		}

		if (repair.Repair) 
		{
			StreamWriter sw1 = new StreamWriter ("database/RepairHistory.txt");
			
			sw1.WriteLine (txt.text); 
			sw1.WriteLine (txt2.text);
			sw1.WriteLine (cost);

			sw1.Close (); 
			cost = RC.i*4;
		}
	}

}
