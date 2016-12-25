using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class RentData : MonoBehaviour {
	public Text txt;
	public int gym=0;
	
	
	
	
	public string st1; 
	public string st2; 

	
	
	public void Info()
	{
		StreamReader streamReader = new StreamReader ("database/GymData.txt");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/GymData.txt");
				st1 = streamReader.ReadLine();
				st2 = streamReader.ReadLine();

				
				if(gym ==0 ){txt.text="Choose a gym";}
				if(gym ==1 ){txt.text=""+st1;}
				if(gym ==2 ){txt.text=""+st2;}

				
				
				
			}
			
		}
		
	}
}
