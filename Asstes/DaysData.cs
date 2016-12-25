using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class DaysData : MonoBehaviour {
	public Text txt;
	public int day=0;

	

	
	public string st1; 
	public string st2; 
	public string st3; 
	public string st4;
	public string st5; 
	public string st6; 
	public string st7; 


	public void Info()
	{
		StreamReader streamReader = new StreamReader ("database/Days.txt");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/Days.txt");
				st1 = streamReader.ReadLine();
				st2 = streamReader.ReadLine();
				st3 = streamReader.ReadLine();
				st4 = streamReader.ReadLine();
				st5 = streamReader.ReadLine();
				st6 = streamReader.ReadLine();
				st7 = streamReader.ReadLine();

				if(day ==0 ){txt.text="Choose a day";}
				if(day ==1 ){txt.text=""+st1;}
				if(day ==2 ){txt.text=""+st2;}
				if(day ==3 ){txt.text=""+st3;}
				if(day ==4 ){txt.text=""+st4;}
				if(day ==5 ){txt.text=""+st5;}
				if(day ==6 ){txt.text=""+st6;}
				if(day ==7 ){txt.text=""+st7;}

	
				
			}
			
		}
		
	}
}
