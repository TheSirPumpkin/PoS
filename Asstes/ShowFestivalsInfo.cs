using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ShowFestivalsInfo : MonoBehaviour {

	public Text txt;

	public void Info()
	{
		StreamReader streamReader1 = new StreamReader ("database/Festival1Info.txt");
		StreamReader streamReader2 = new StreamReader ("database/Festival2Info.txt");
		StreamReader streamReader3 = new StreamReader ("database/Festival3Info.txt");
		StreamReader streamReader4 = new StreamReader ("database/Festival4Info.txt");
		StreamReader streamReader11 = new StreamReader ("database/Festival1Info1.txt");
		StreamReader streamReader22 = new StreamReader ("database/Festival2Info1.txt");
		StreamReader streamReader33 = new StreamReader ("database/Festival3Info1.txt");
		StreamReader streamReader44 = new StreamReader ("database/Festival4Info1.txt");

		string st = streamReader1.ReadLine();
		string st1 = streamReader1.ReadLine();
		string st2 = streamReader1.ReadLine();

		string str = streamReader2.ReadLine();
		string str1 = streamReader2.ReadLine();
		string str2 = streamReader2.ReadLine();

		string strg = streamReader3.ReadLine();
		string strg1 = streamReader3.ReadLine();
		string strg2 = streamReader3.ReadLine();

		string strgn = streamReader4.ReadLine();
		string strgn1 = streamReader4.ReadLine();
		string strgn2 = streamReader4.ReadLine();

		string sst = streamReader11.ReadLine();
		string sst1 = streamReader11.ReadLine();
		string sst2 = streamReader11.ReadLine();

		string sstr = streamReader22.ReadLine();
		string sstr1 = streamReader22.ReadLine();
		string sstr2 = streamReader22.ReadLine();

		string sstrg = streamReader33.ReadLine();
		string sstrg1 = streamReader33.ReadLine();
		string sstrg2 = streamReader33.ReadLine();

		string sstrgn = streamReader44.ReadLine();
		string sstrgn1 = streamReader44.ReadLine();
		string sstrgn2 = streamReader44.ReadLine();

		txt.text=st+" "+st1+" "+st2+" ; "+str+" "+str1+" "+str2+" ; "+strg+" "+strg1+" "+strg2+" ; "+strgn+" "+strgn1+" "+strgn2+" ; "+sst+" "+sst1+" "+sst2+" ; "+sstr+" "+sstr1+" "+sstr2+" ; "+sstrg+" "+sstrg1+" "+sstrg2+" ; "+sstrgn+" "+sstrgn1+" "+sstrgn2+" ; ";
	}
}
