using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;


public class ChangePAssword : MonoBehaviour {
	public InputField Password;
	//public InputField OldName;
	public InputField NewPassword;
	//public AccountData Adata;
	public AccountLogIn Loginfo;
	
	//string oldName;
	string password;
	string newPassword;
	bool correctPass;

	public string accName1;
	public string accName2;

	
	public void changePassword()
	{
		//oldName = OldName.text;
		password = Password.text;
		newPassword = NewPassword.text;
		
		StreamReader streamReader = new StreamReader ("database/accountDatabase.txt");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/accountDatabase.txt");
				string st = streamReader.ReadLine();
				string st1 = streamReader.ReadLine();
				accName1=st;
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
				accName2=str;
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
			
			sw.WriteLine (accName1); 
			sw.WriteLine (newPassword);
			
			
			sw.Close ();
		}
		if (correctPass && Loginfo.account2Logged) {
			StreamWriter sw2 = new StreamWriter ("database/accountDatabase2.txt");
			
			sw2.WriteLine (accName2); 
			sw2.WriteLine (newPassword);
			
			
			sw2.Close ();
		}
		
	}

}
