using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class AssignRole : MonoBehaviour {

	public Text role,fest,clubM;
	public ScrollFest festival;

	public void Confirm()
	{
		if (festival.festival == 1) {
			StreamWriter sw = new StreamWriter ("database/AssignedRoles1.txt");
		
			sw.WriteLine (role.text); 
			sw.WriteLine (fest.text);
			sw.WriteLine (clubM.text);
		
		
			sw.Close ();
		}

		else if (festival.festival == 2) {
			StreamWriter sw = new StreamWriter ("database/AssignedRoles2.txt");
			
			sw.WriteLine (role.text); 
			sw.WriteLine (fest.text);
			sw.WriteLine (clubM.text);
			
			
			sw.Close ();
		}

		else if (festival.festival == 3) {
			StreamWriter sw = new StreamWriter ("database/AssignedRoles3.txt");
			
			sw.WriteLine (role.text); 
			sw.WriteLine (fest.text);
			sw.WriteLine (clubM.text);
			
			
			sw.Close ();
		}
		else if (festival.festival == 4) {
			StreamWriter sw = new StreamWriter ("database/AssignedRoles4.txt");
			
			sw.WriteLine (role.text); 
			sw.WriteLine (fest.text);
			sw.WriteLine (clubM.text);
			
			
			sw.Close ();
		}
	}
}
