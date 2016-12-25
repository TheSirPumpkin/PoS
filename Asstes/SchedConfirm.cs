using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class SchedConfirm : MonoBehaviour {

	public DaysData dData;
	public AssignTrainer AT;

	public Text txt;

	public void createSched()
	{
		if (dData.day == 1 && AT.trainer == 1) {
			StreamWriter sw = new StreamWriter ("database/MondaySched.txt");
			
			sw.WriteLine (dData.st1); 
			sw.WriteLine (AT.st);
			sw.WriteLine (txt.text);

			
			
			sw.Close (); 
		}

		if (dData.day == 2 && AT.trainer == 1) {
			StreamWriter sw = new StreamWriter ("database/TuesdaySched.txt");
			
			sw.WriteLine (dData.st2); 
			sw.WriteLine (AT.st);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 3 && AT.trainer == 1) {
			StreamWriter sw = new StreamWriter ("database/WednesdaySched.txt");
			
			sw.WriteLine (dData.st3); 
			sw.WriteLine (AT.st);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 4 && AT.trainer == 1) {
			StreamWriter sw = new StreamWriter ("database/ThursdaySched.txt");
			
			sw.WriteLine (dData.st4); 
			sw.WriteLine (AT.st);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 5 && AT.trainer == 1) {
			StreamWriter sw = new StreamWriter ("database/FridaySched.txt");
			
			sw.WriteLine (dData.st5); 
			sw.WriteLine (AT.st);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 6 && AT.trainer == 1) {
			StreamWriter sw = new StreamWriter ("database/SaturdaySched.txt");
			
			sw.WriteLine (dData.st6); 
			sw.WriteLine (AT.st);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 7 && AT.trainer == 1) {
			StreamWriter sw = new StreamWriter ("database/SundaySched.txt");
			
			sw.WriteLine (dData.st7); 
			sw.WriteLine (AT.st);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}

		if (dData.day == 1 && AT.trainer == 2) {
			StreamWriter sw = new StreamWriter ("database/MondaySched2.txt");
			
			sw.WriteLine (dData.st1); 
			sw.WriteLine (AT.str);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		
		if (dData.day == 2 && AT.trainer == 2) {
			StreamWriter sw = new StreamWriter ("database/TuesdaySched2.txt");
			
			sw.WriteLine (dData.st2); 
			sw.WriteLine (AT.str);
			sw.WriteLine (txt.text);
			

			sw.Close (); 
		}
	
		if (dData.day == 3 && AT.trainer == 2) {
			StreamWriter sw = new StreamWriter ("database/WednesdaySched2.txt");
			
			sw.WriteLine (dData.st3); 
			sw.WriteLine (AT.str);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 4 && AT.trainer == 2 ) {
			StreamWriter sw = new StreamWriter ("database/ThursdaySched2.txt");
			
			sw.WriteLine (dData.st4); 
			sw.WriteLine (AT.str);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 5 && AT.trainer == 2) {
			StreamWriter sw = new StreamWriter ("database/FridaySched2.txt");
			
			sw.WriteLine (dData.st5); 
			sw.WriteLine (AT.str);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 6 && AT.trainer == 2) {
			StreamWriter sw = new StreamWriter ("database/SaturdaySched2.txt");
			
			sw.WriteLine (dData.st6); 
			sw.WriteLine (AT.str);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}
		if (dData.day == 7 && AT.trainer == 2) {
			StreamWriter sw = new StreamWriter ("database/SundaySched2.txt");
			
			sw.WriteLine (dData.st7); 
			sw.WriteLine (AT.str);
			sw.WriteLine (txt.text);
			
			
			
			sw.Close (); 
		}


	}
}