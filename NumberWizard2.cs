using UnityEngine;
using System.Collections;

public class NumberWizard2 : MonoBehaviour {

	// Use this for initialization
	int max;
	int min = 1;
	int guess;
		
	void Start () {
		StartGame ();	
	}
	void StartGame () {
		max = 1000000;
		min = 0;
		guess = Random.Range(min, max);
				
		print ("========================");
		print ("Welcome To Number Wizard 2");
		print ("Pick A Number In Your Head, Just Don't Tell Me...");
		
		print ("Up Arrow Key = Higher, Down Arrow Key = Lower,equal = equal");
		print ("Pick A Number 0-1 million"); 
		print ("Hit Enter If I Got The Number Right!");
		
		print ("========================");
		print ("My First Guess Is " + guess);
		
		max += 1;
		
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess();
			print("Higher Or Lower Than " + guess);
		}
		
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
			print("Higher Or Lower Than " + guess); 
		}
		
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I WON OMG! O... Yeah You too...");
			StartGame ();	

		}
			
	  }
	  void NextGuess () {
	  guess = Random.Range(min, max);  
	}
}
