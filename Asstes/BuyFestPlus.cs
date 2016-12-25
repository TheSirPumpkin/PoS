using UnityEngine;
using System.Collections;

public class BuyFestPlus : MonoBehaviour {

	public	BuyTickets plus;
	
	public void Plus()
	{
		if(plus.festival<=3)
			plus.festival = plus.festival + 1;
	}
}
