using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ClubMemberData : MonoBehaviour {

	public Text txt,txt1,txt2,txt3;
	public int member=0;
	
	//public Text AccountTickets;
	
	public string st; 
	public string st1; 
	public string st2; 
	public string st3;
	
	public void ChooseMember()
	{
		StreamReader streamReader = new StreamReader ("database/ClubMembersDatabase.txt");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/ClubMembersDatabase.txt");
				st = streamReader.ReadLine();
				st1 = streamReader.ReadLine();
				st2 = streamReader.ReadLine();
				st3 = streamReader.ReadLine();
				if(member ==0 ){txt.text="Choose a club member";}
				if(member ==1 ){txt.text=""+st;}
				if(member ==2 ){txt1.text=""+st1;}
				if(member ==3 ){txt2.text=""+st2;}
				if(member ==4 ){txt3.text=""+st3;}
				
			}
			
		}
		
	}
}
