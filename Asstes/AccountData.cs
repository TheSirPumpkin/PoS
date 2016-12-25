using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;



public class AccountData : MonoBehaviour 
{
	public InputField Name;
	public InputField Password;

public string name;
public string password;
public double ID=1;

public string name2;
public string password2;
public double ID2=1;


	
	public void Data(){

		name = Name.text;
		password = Password.text;

		name2 = Name.text;
		password2 = Password.text;


		if (System.IO.File.Exists (@"D:\ipz\database\accountDatabase.txt")) {

			StreamWriter sw2 = new StreamWriter ("database/accountDatabase2.txt");
	
			sw2.WriteLine (name2); 
			sw2.WriteLine (password2);
			//sw2.WriteLine (ID2);


			sw2.Close (); 
		} else {StreamWriter sw = new StreamWriter ("database/accountDatabase.txt");
			
			sw.WriteLine (name); 
			sw.WriteLine (password);
		//	sw.WriteLine (ID);
			
			
			sw.Close (); 
		}
				
	}
	 
		  
}
	
	
	
	
	
	
