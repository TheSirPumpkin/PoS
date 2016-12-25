using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ShowTicetsInfo : MonoBehaviour {

	public Text txt;
	public int tickets=0;
	public AccountLogIn account;
	
	//public Text AccountTickets;
	
	public string st; 
	public string st1; 
	public string st2; 
	public string st3;
	
	public void ShowTicket()
	{
		if (account.account1Logged) {
			StreamReader streamReader = new StreamReader ("database/TicketsAmount.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TicketsAmount.txt");
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					st3 = streamReader.ReadLine ();
					if (tickets == 0) {
						txt.text = "No tickets";
					}
					if (tickets == 1) {
						txt.text = "CallOfHeroes" + st;
					}
					if (tickets == 2) {
						txt.text = "Putivl" + st1;
					}
					if (tickets == 3) {
						txt.text = "OldFortress" + st2;
					}
					if (tickets == 4) {
						txt.text = "SoftAnger" + st3;
					}
				
				}
			
			}
		}
		if (account.account2Logged) {
			StreamReader streamReader = new StreamReader ("database/TicketsAmount2.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TicketsAmount2.txt");
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					st3 = streamReader.ReadLine ();
					if (tickets == 0) {
						txt.text = "No tickets";
					}
					if (tickets == 1) 
						txt.text = "CallOfHeroes" + st;
					}
					if (tickets == 2) {
						txt.text = "Putivl" + st1;
					}
					if (tickets == 3) {
						txt.text = "OldFortress" + st2;
					}
					if (tickets == 4) {
						txt.text = "SoftAnger" + st3;
					}
					
				}
				
			}
		}
		
	}

