using UnityEngine;
using System.Collections;

public class TicketInfoPlus : MonoBehaviour {

	public	 ShowTicetsInfo plus;
	
	public void Plus()
	{
		if(plus.tickets<=3)
			plus.tickets = plus.tickets + 1;
	}
}
