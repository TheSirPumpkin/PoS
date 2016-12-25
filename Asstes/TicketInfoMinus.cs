using UnityEngine;
using System.Collections;

public class TicketInfoMinus : MonoBehaviour {

	public	 ShowTicetsInfo minus;
	
	public void Minus()
	{
		if(minus.tickets>=1)
			minus.tickets = minus.tickets - 1;
	}
}
