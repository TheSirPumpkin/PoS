using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class Rent : MonoBehaviour {

	public RentData RD;
	public Text RstartYear, RstartMonth, RstartDay, RfinishYear, RfinishMonth, RfinishDay, RentCostPerDay;
	public System.DateTime RentStart ;
	public System.DateTime RentFinish;
	public TimeSpan res;


	public void rent()
	{
		RentStart = new System.DateTime(Int32.Parse(RstartYear.text),Int32.Parse(RstartMonth.text),Int32.Parse(RstartDay.text), 0, 0, 0);
		RentFinish = new System.DateTime(Int32.Parse(RfinishYear.text),Int32.Parse(RfinishMonth.text),Int32.Parse(RfinishDay.text), 0, 0, 0);
		res = RentFinish - RentStart;

		if (RD.gym == 1) {
			StreamWriter sw = new StreamWriter ("database/Gym1Data.txt");
			
			sw.WriteLine (RentStart); 
			sw.WriteLine (RentFinish);
			sw.WriteLine (res.Days);
			sw.WriteLine(RentCostPerDay.text);

			
			sw.Close (); 
		}
		if (RD.gym == 2) {
			StreamWriter sw = new StreamWriter ("database/Gym2Data.txt");
			
			sw.WriteLine (RentStart); 
			sw.WriteLine (RentFinish);
			sw.WriteLine (res.Days);
			sw.WriteLine(RentCostPerDay.text);
			
			
			sw.Close (); 
		}

		 

		
		
	
	}
}
