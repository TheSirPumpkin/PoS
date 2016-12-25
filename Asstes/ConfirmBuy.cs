using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ConfirmBuy : MonoBehaviour {
	public BuyTickets ticketInfo;
	public AccountLogIn account;

	public string st1,st2,st3,st4;
	public string str1,str2,str3,str4;
	public int CoH, P, OF, SA;//кол-во билетов на фесты
	//public int CoH2, P2, OF2, SA2;

	void Start()
	{
		if (account.account1Logged) {
			StreamReader streamReader = new StreamReader ("database/TicketsAmount.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TicketsAmount.txt");
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					st3 = streamReader.ReadLine ();
					st4 = streamReader.ReadLine ();
					OF = System.Int32.Parse (st1);
					CoH = System.Int32.Parse (st2);
					P = System.Int32.Parse (st3);
					SA = System.Int32.Parse (st4);
					streamReader.Close ();
				}
			}
		}
		else if (account.account2Logged) {Debug.Log("ABRAKADABRA");
			StreamReader streamReader2 = new StreamReader ("database/TicketsAmount2.txt");
			if (streamReader2 != null) {
				while (!streamReader2.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TicketsAmount2.txt");
					str1 = streamReader2.ReadLine ();
					str2 = streamReader2.ReadLine ();
					str3 = streamReader2.ReadLine ();
					str4 = streamReader2.ReadLine ();
					OF = System.Int32.Parse (str1);
					CoH = System.Int32.Parse (str2);
					P = System.Int32.Parse (str3);
					SA = System.Int32.Parse (str4);
					streamReader2.Close ();
				}
			}
		}


	}
	public void Confirm(){
		if (account.account1Logged) {
			if(ticketInfo.festival ==1 ){
			StreamWriter sw = new StreamWriter ("database/account1Festivals.txt");
		//если строка не пуста то кол во билетов на фест +1
					
			sw.WriteLine (ticketInfo.txt.text);
				OF++;
				
						sw.Close ();
						}


			if(ticketInfo.festival ==2 ){
				StreamWriter sw = new StreamWriter ("database/account1Festivals1.txt");
				
				sw.WriteLine (ticketInfo.txt.text);
				CoH++;
				
				sw.Close (); }
			if(ticketInfo.festival ==3 ){
				StreamWriter sw = new StreamWriter ("database/account1Festivals2.txt");
				
				sw.WriteLine (ticketInfo.txt.text);
				P++;
				
				sw.Close (); }
			if(ticketInfo.festival ==4 ){
				StreamWriter sw = new StreamWriter ("database/account1Festivals3.txt");
				
				sw.WriteLine (ticketInfo.txt.text);
				SA++;
				
				sw.Close (); }
		
			StreamWriter swrt = new StreamWriter ("database/TicketsAmount.txt");
			
			swrt.WriteLine (CoH);
			swrt.WriteLine (P);
			swrt.WriteLine (OF);
			swrt.WriteLine (SA);
			

			swrt.Close (); 

		}
		else if (account.account2Logged) {
			if(ticketInfo.festival ==1 ){
				StreamWriter swr = new StreamWriter ("database/account2Festivals.txt");

				swr.WriteLine (ticketInfo.txt.text);
				OF++;
				
				swr.Close (); }
			if(ticketInfo.festival ==2 ){
				StreamWriter swr = new StreamWriter ("database/account2Festivals1.txt");
				
				swr.WriteLine (ticketInfo.txt.text);
				CoH++;
				
				swr.Close (); }
			if(ticketInfo.festival ==3 ){
				StreamWriter swr = new StreamWriter ("database/account2Festivals2.txt");
				
				swr.WriteLine (ticketInfo.txt.text);
				P++;
				
				swr.Close (); }
			if(ticketInfo.festival ==4 ){
				StreamWriter swr = new StreamWriter ("database/account2Festivals3.txt");
				
				swr.WriteLine (ticketInfo.txt.text);
				SA++;
				
				swr.Close (); }
			StreamWriter swrtr2 = new StreamWriter ("database/TicketsAmount2.txt");
			
			swrtr2.WriteLine (CoH);
			swrtr2.WriteLine (P);
			swrtr2.WriteLine (OF);
			swrtr2.WriteLine (SA);
			
			
			swrtr2.Close (); 
	}
}
}
