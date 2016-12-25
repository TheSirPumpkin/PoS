using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class BuyTickets : MonoBehaviour {
	public Text txt,txt1,txt2,txt3;
	public int festival=0;

	//public Text AccountTickets;

	public string st; 
	public string st1; 
	public string st2; 
	public string st3;
		
		public void BuyTicket()
	{
		StreamReader streamReader = new StreamReader ("database/festivalsData.txt");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/festivalsData.txt");
				st = streamReader.ReadLine();
				st1 = streamReader.ReadLine();
				st2 = streamReader.ReadLine();
				st3 = streamReader.ReadLine();
				if(festival ==0 ){txt.text="Choose a festival";}
				if(festival ==1 ){txt.text=""+st;}
				if(festival ==2 ){txt1.text=""+st1;}
				if(festival ==3 ){txt2.text=""+st2;}
				if(festival ==4 ){txt3.text=""+st3;}

	}

}

	}
}
