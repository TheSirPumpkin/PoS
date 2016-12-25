using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public class ShowSchedule : MonoBehaviour {

	public Text time, gym;
	public DaysData DD;
	public AssignTrainer AT;
	public string st, st1, st2;
	public string str, str1, str2;

	public void Show()
	{
		if (DD.day == 1 && AT.trainer==1) {
			StreamReader streamReader = new StreamReader ("database/MondaySched.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/MondaySched.txt");
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
		
			StreamReader streamReader1 = new StreamReader ("database/Trainer1Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer1Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			

		}

		if (DD.day == 1 && AT.trainer==2) {
			StreamReader streamReader = new StreamReader ("database/MondaySched2.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/MondaySched2.txt");
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer2Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer2Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		if (DD.day == 2 && AT.trainer==1) {
			StreamReader streamReader = new StreamReader ("database/TuesdaySched.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TuesdaySched.txt");
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer1Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer1Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		
		if (DD.day == 2 && AT.trainer==2) {
			StreamReader streamReader = new StreamReader ("database/TuesdaySched2.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/TuesdaySched2.txt");
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer2Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer2Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		if (DD.day == 3 && AT.trainer==1) {
			StreamReader streamReader = new StreamReader ("database/WednesdaySched.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer1Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer1Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		
		if (DD.day == 3 && AT.trainer==2) {
			StreamReader streamReader = new StreamReader ("database/WednesdaySched2.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer2Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer2Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		if (DD.day == 4 && AT.trainer==1) {
			StreamReader streamReader = new StreamReader ("database/ThursdaySched.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer1Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer1Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		
		if (DD.day == 4 && AT.trainer==2) {
			StreamReader streamReader = new StreamReader ("database/ThursdaySched2.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer2Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer2Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		if (DD.day == 5 && AT.trainer==1) {
			StreamReader streamReader = new StreamReader ("database/FridaySched.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer1Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer1Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		
		if (DD.day == 5 && AT.trainer==2) {
			StreamReader streamReader = new StreamReader ("database/FridaySched2.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer2Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer2Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		if (DD.day == 6 && AT.trainer==1) {
			StreamReader streamReader = new StreamReader ("database/SaturdaySched.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer1Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer1Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		
		if (DD.day == 6 && AT.trainer==2) {
			StreamReader streamReader = new StreamReader ("database/SaturdaySched2.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer2Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer2Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		if (DD.day == 7 && AT.trainer==1) {
			StreamReader streamReader = new StreamReader ("database/SundaySched.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer1Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer1Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
		
		if (DD.day == 7 && AT.trainer==2) {
			StreamReader streamReader = new StreamReader ("database/SundaySched2.txt");
			if (streamReader != null) {
				while (!streamReader.EndOfStream) {
					st = streamReader.ReadLine ();
					st1 = streamReader.ReadLine ();
					st2 = streamReader.ReadLine ();
					time.text=st2;
				}
				
			}
			
			StreamReader streamReader1 = new StreamReader ("database/Trainer2Gym.txt");
			if (streamReader1 != null) {
				while (!streamReader1.EndOfStream) {
					string[] rows = File.ReadAllLines ("database/Trainer2Gym.txt");
					str = streamReader1.ReadLine ();
					
					gym.text=str;
				}
				
			}
			
			
		}
	}
}
