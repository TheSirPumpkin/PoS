using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class AddEvent : MonoBehaviour {
	public EventCounter EC;
	public Text txt, time, name;
	public string st,st1;

	public void Add()//каждый раз при записи новго ивента надо генерить новый файл с рандомным именем, пока работает костылем и позволяет перезаписывать второйй файл
	{
		if (EC.count ==1)
		{
			StreamReader streamReader = new StreamReader ("database/Festival1Info.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Festival1Info.txt");
					st = streamReader.ReadLine();

					}}
		if(st==""){
			StreamWriter sw = new StreamWriter ("database/Festival1Info.txt");
			
			sw.WriteLine (name.text); 
			sw.WriteLine (time.text);
			sw.WriteLine ("Festival OldFortress");
			
			
						sw.Close (); }
			else
					{
						StreamWriter sw = new StreamWriter ("database/Festival1Info1.txt");
						
						sw.WriteLine (name.text); 
						sw.WriteLine (time.text);
						sw.WriteLine ("Festival OldFortress");
				sw.Close ();
					}


		
			}
		if (EC.count ==2)
		{
			StreamReader streamReader = new StreamReader ("database/Festival2Info.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Festival2Info.txt");
					st = streamReader.ReadLine();
					
				}}
			if(st==""){
				StreamWriter sw = new StreamWriter ("database/Festival2Info.txt");
				
				sw.WriteLine (name.text); 
				sw.WriteLine (time.text);
				sw.WriteLine ("Festival CallOfHeroes");
				
				
				sw.Close (); }
			else
			{
				StreamWriter sw = new StreamWriter ("database/Festival2Info1.txt");
				
				sw.WriteLine (name.text); 
				sw.WriteLine (time.text);
				sw.WriteLine ("Festival CallOfHeroes");
				sw.Close ();
			}
			
		}
		if (EC.count ==3)
		{
			StreamReader streamReader = new StreamReader ("database/Festival3Info.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Festival3Info.txt");
					st = streamReader.ReadLine();
					
				}}
			if(st==""){
				StreamWriter sw = new StreamWriter ("database/Festival3Info.txt");
				
				sw.WriteLine (name.text); 
				sw.WriteLine (time.text);
				sw.WriteLine ("Festival Putivl");
				
				
				sw.Close (); }
			else
			{
				StreamWriter sw = new StreamWriter ("database/Festival3Info1.txt");
				
				sw.WriteLine (name.text); 
				sw.WriteLine (time.text);
				sw.WriteLine ("Festival Putivl");
				sw.Close ();
			}
			
		}
		if (EC.count ==4)
		{
			StreamReader streamReader = new StreamReader ("database/Festival4Info.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Festival4Info.txt");
					st = streamReader.ReadLine();
					
				}}
			if(st==""){
				StreamWriter sw = new StreamWriter ("database/Festival4Info.txt");
				
				sw.WriteLine (name.text); 
				sw.WriteLine (time.text);
				sw.WriteLine ("Festival SoftAnger");
				
				
				sw.Close (); }
			else
			{
				StreamWriter sw = new StreamWriter ("database/Festival4Info1.txt");
				
				sw.WriteLine (name.text); 
				sw.WriteLine (time.text);
				sw.WriteLine ("Festival SoftAnger");
				sw.Close ();
			}
			
		}
	}
}
