using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class AssignTrainer : MonoBehaviour {

	public Text txt,txt1,txt2;
	public int trainer=0;
	public int salary= 0;
	public bool isAssign=true;

	
	//public Text AccountTickets;
	
	public string st; 
	public string st1; 
	public string str; 
	public string str1; 

	
	public void Info()
	{ 
		if (trainer == 1) {
			StreamReader streamReader = new StreamReader ("database/accountDatabase.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/accountDatabase.txt");
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					txt.text=""+st;
					if(isAssign){
						salary = Int32.Parse(txt1.text);}
				
			
				
				}
			
			}
		}
		if (trainer == 2) {
			StreamReader streamReader1 = new StreamReader ("database/accountDatabase2.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/accountDatabase2.txt");
					str = streamReader1.ReadLine ();
					str1 = streamReader1.ReadLine ();
					txt.text=""+str;
					if(isAssign){
						salary = Int32.Parse(txt1.text);}
				
					
					
				}
				
			}
		}
	}
}
