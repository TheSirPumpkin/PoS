using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class AddClubMember : MonoBehaviour {
	public Text txt;

	public void Add()
	{
		StreamWriter sw = new StreamWriter("database/ClubMembersDatabase.txt",true);
		sw.WriteLine (txt.text); 
		sw.Close (); 
	}
}
