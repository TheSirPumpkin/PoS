using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class AssignTrainerConfirm : MonoBehaviour {

	public AssignTrainer AT;
	public RentData RD;

	public void confirm()
	{
		if (AT.trainer == 1) {
			StreamWriter sw = new StreamWriter ("database/TrainerData.txt");
			
			sw.WriteLine (AT.st); 
			sw.WriteLine (AT.salary);

			sw.Close (); 
		}
		if (AT.trainer == 2) {
			StreamWriter sw2 = new StreamWriter ("database/TrainerData2.txt");
			
			sw2.WriteLine (AT.str); 
			sw2.WriteLine (AT.salary);
			
			sw2.Close (); 

		}
		if(RD.gym==1 && AT.trainer == 1){StreamWriter sw = new StreamWriter ("database/Trainer1Gym.txt");//чтоб залов было много ("database/Trainer1Gym.txt",true)
			
			sw.WriteLine ("Gym1"); 
			
			sw.Close (); }
		if(RD.gym==2 && AT.trainer == 1){StreamWriter sw = new StreamWriter ("database/Trainer1Gym.txt");
			
			sw.WriteLine ("Gym2"); 
			
			sw.Close (); }
		if(RD.gym==1 && AT.trainer == 2){StreamWriter sw = new StreamWriter ("database/Trainer2Gym.txt");
			
			sw.WriteLine ("Gym1"); 
			
			sw.Close (); }
		if(RD.gym==2 && AT.trainer == 2){StreamWriter sw = new StreamWriter ("database/Trainer2Gym.txt");
			
			sw.WriteLine ("Gym2"); 
			
			sw.Close (); }
	}
}
