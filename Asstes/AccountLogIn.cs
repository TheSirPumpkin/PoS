using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;


public class AccountLogIn : MonoBehaviour {
	
	public InputField logName;
	public InputField logPassword;

	public string Logname;
	public string Logpassword;

	public string managerName="Dima";
	public string managerPassword="1232387";

	public GameObject mainMenu;
	public GameObject managerMenu;

	public bool account1Logged;
	public bool account2Logged;


	
	public void Log()
	{
	 Logname=logName.text;
	 Logpassword=logPassword.text;
		
		StreamReader streamReader = new StreamReader ("database/accountDatabase.txt");
		if (streamReader != null) {
			while (!streamReader.EndOfStream) {
				string[] rows = File.ReadAllLines ("database/accountDatabase.txt");
				string st = streamReader.ReadLine();
				string st1 = streamReader.ReadLine();
				Debug.Log(" первая строка" + " "+st + "вторая строка "+" "+st1);
				if (st ==  Logname && st1 == Logpassword )
				{Debug.Log("Данные верны");
					mainMenu.gameObject.SetActive(true);
						account1Logged=true;
				}
				else if (Logname == managerName && Logpassword == managerPassword )
				{Debug.Log("Батя в здании");
					managerMenu.gameObject.SetActive(true);
				}
				else if (st !=  Logname || st1 != Logpassword )
				{Debug.Log("Данные не верны");}


					
			}

			StreamReader streamReader2 = new StreamReader ("database/accountDatabase2.txt");
			if (streamReader2 != null) {
				while (!streamReader2.EndOfStream) {
					string[] rows2 = File.ReadAllLines ("database/accountDatabase2.txt");
					string str = streamReader2.ReadLine();
					string str1 = streamReader2.ReadLine();
					Debug.Log(" первая строка" + " "+ str + "вторая строка "+ " "+str1);
					if (str ==  Logname && str1 == Logpassword )
					{Debug.Log("Данные верны");
						mainMenu.gameObject.SetActive(true);
							account2Logged=true;
					}
					else if (Logname == managerName && Logpassword == managerPassword )
					{Debug.Log("Батя в здании");
						managerMenu.gameObject.SetActive(true);}
					else if (str !=  Logname || str1 != Logpassword )
					{Debug.Log("Данные не верны");}
					
					
					
				}


			
		}


	}
	
	
}
}
