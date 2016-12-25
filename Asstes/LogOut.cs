using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;




public class LogOut : MonoBehaviour {
	public AccountLogIn Log;
	public void OnClick()
	{
		Log.account1Logged = false;
		Log.account2Logged = false;
	}


}
