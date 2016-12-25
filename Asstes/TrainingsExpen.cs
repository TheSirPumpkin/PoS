using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class TrainingsExpen : MonoBehaviour {

	public RentData RD;
	public AssignTrainer AT;

	public Text txt;

	public int sal;
	public int rentCost;
	public string st,st1,st2,st3,str,str1,str2,str3,strn,strn1,strn2,strn3,strng,strng1,strng2,strng3;

	public void Calculate()
	{
		if (RD.gym == 1) {
			StreamReader streamReader = new StreamReader ("database/Gym1Data.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Gym1Data.txt");
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					st3 = streamReader.ReadLine ();
					
					rentCost =Int32.Parse(st2)*Int32.Parse(st3);
					
				}
				
			}
		}
		if (RD.gym == 2) {
			StreamReader streamReader1 = new StreamReader ("database/Gym2Data.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Gym2Data.txt");
					strng = streamReader1.ReadLine ();
					strng1 = streamReader1.ReadLine ();
					strng2 = streamReader1.ReadLine ();
					strng3 = streamReader1.ReadLine ();
					
					rentCost =Int32.Parse(strng2)*Int32.Parse(strng3);
					
				}
				
			}
		}
		if (AT.trainer == 1 && RD.gym == 1) {
			StreamReader streamReader2 = new StreamReader ("database/TrainerData.txt");
			if (streamReader2 != null) {
				while (!streamReader2.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TrainerData.txt");
					 str = streamReader2.ReadLine ();
					 str1 = streamReader2.ReadLine ();
					
					sal=Int32.Parse(str1)*Int32.Parse(st2);
					
				}
				
			}
		}

		if (AT.trainer == 1 && RD.gym == 2) {
			StreamReader streamReader3 = new StreamReader ("database/TrainerData.txt");
			if (streamReader3 != null) {
				while (!streamReader3.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TrainerData.txt");
					str = streamReader3.ReadLine ();
					str1 = streamReader3.ReadLine ();
					
					sal=Int32.Parse(str1)*Int32.Parse(strng2);
					
				}
				
			}
		}
		if (AT.trainer == 2 && RD.gym == 1) {
			StreamReader streamReader4 = new StreamReader ("database/TrainerData2.txt");
			if (streamReader4 != null) {
				while (!streamReader4.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TrainerData2.txt");
					 strn = streamReader4.ReadLine ();
					  strn1 = streamReader4.ReadLine ();
					
					sal=Int32.Parse(strn1)*Int32.Parse(st2);
					
				}
				
			}
		}

		if (AT.trainer == 2 && RD.gym == 2) {
			StreamReader streamReader4 = new StreamReader ("database/TrainerData2.txt");
			if (streamReader4 != null) {
				while (!streamReader4.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TrainerData2.txt");
					strn = streamReader4.ReadLine ();
					strn1 = streamReader4.ReadLine ();
					
					sal=Int32.Parse(strn1)*Int32.Parse(strng2);
					
				}
				
			}
		}
		int done = sal + rentCost;
		txt.text = "" + done;

	}

}
