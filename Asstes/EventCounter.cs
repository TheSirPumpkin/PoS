using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class EventCounter : MonoBehaviour {

	public int count;
	public Text txt;

	public void Count()
	{
		StreamReader streamReader = new StreamReader ("database/festivalsData.txt");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/festivalsData.txt");
				string st = streamReader.ReadLine();
				string st1 = streamReader.ReadLine();
				string st2 = streamReader.ReadLine();
				string st3 = streamReader.ReadLine();
				if(count ==0 ){txt.text="Choose a festival";}
				if(count ==1 ){txt.text=""+st;}
				if(count ==2 ){txt.text=""+st1;}
				if(count ==3 ){txt.text=""+st2;}
				if(count ==4 ){txt.text=""+st3;}
	}
}
	}
}