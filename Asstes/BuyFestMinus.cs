using UnityEngine;
using System.Collections;

public class BuyFestMinus : MonoBehaviour {

	public	BuyTickets minus;

	public void Minus()
	{
		if(minus.festival>=1)
		minus.festival = minus.festival - 1;
	}


}
