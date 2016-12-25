using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour {

	public InputField Password;
	//public InputField OldName;
	public InputField NewName;
	//public AccountData Adata;
	public AccountLogIn Loginfo;

	//string oldName;
	string password;
	string newName;
	bool correctPass;

	public void changeName()
	{
		//oldName = OldName.text;
		password = Password.text;
		newName = NewName.text;

		StreamReader streamReader = new StreamReader ("database/accountDatabase.txt");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/accountDatabase.txt");
				string st = streamReader.ReadLine();
				string st1 = streamReader.ReadLine();

				if (password == st1)
				{
					//Adata.name=newName;
					correctPass=true;
				}
			}

			streamReader.Close();

	}

		StreamReader streamReader2 = new StreamReader ("database/accountDatabase2.txt");
		if (streamReader2 != null) {
			while (!streamReader2.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/accountDatabase2.txt");
				string str = streamReader2.ReadLine();
				string str1 = streamReader2.ReadLine();
				
				if (password == str1)
				{
					//Adata.name=newName;
					correctPass=true;
				}
			}
			
			streamReader2.Close();
			
		}
		if (correctPass && Loginfo.account1Logged) {
			StreamWriter sw = new StreamWriter ("database/accountDatabase.txt");
		
			sw.WriteLine (newName); 
			sw.WriteLine (password);
		
		
			sw.Close ();
		}
		if (correctPass && Loginfo.account2Logged) {
			StreamWriter sw2 = new StreamWriter ("database/accountDatabase2.txt");
			
			sw2.WriteLine (newName); 
			sw2.WriteLine (password);
			
			
			sw2.Close ();
		}
		
	}
		
	}



