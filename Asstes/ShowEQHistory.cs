using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ShowEQHistory : MonoBehaviour {
	public HistoryCraft craft;
	public HistoryRepair repair;
	public Text txt;

	public void Show()
	{
		if (craft.Craft) {
			StreamReader streamReader = new StreamReader ("database/CraftHistory.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/CraftHistory.txt");
					string st = streamReader.ReadLine ();
					string st1 = streamReader.ReadLine ();
					string st2 = streamReader.ReadLine ();
					txt.text = "" + st + " " + st1 + " cost" + st2;


				}
			}
		}
		
		if (repair.Repair) 
		{
					StreamReader streamReader2 = new StreamReader ("database/RepairHistory.txt");
					if (streamReader2 != null) {
						while (!streamReader2.EndOfStream) {
							string[] rows = File.ReadAllLines ("database/RepairHistory.txt");
							string str = streamReader2.ReadLine();
							string str1 = streamReader2.ReadLine();
							string str2 = streamReader2.ReadLine();
							txt.text=""+str+" "+str1+" cost"+str2;
		}
	}

}
			}
	}

