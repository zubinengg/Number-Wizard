using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max = 1000;
	int min = 1;
	int guess = 500;
	void Start () 
	{
		StartGame();
	
	}
	
	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;
		print ("====================================");
		print ("Welcome to NUmber Wizard..........");	
		print ("Pick a number");
		
		
		print ("The highest number you can print is : " + max);
		print ("The Minimun number you can print is : " + min);
		
		
		print ("Is the number higher or lower than "+guess+"?");
		print (" Press upArrow for higher, downArrow for lower and enter for equal");
	}
	
	void NextGuess()
	{
		guess=(min+max)/2;
		print ("Is the number higher or lower than "+guess+"?");
	}
	// Update is called once per frame
	void Update () //
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			print("Up Arrow was pressed");
			min=guess;
			NextGuess();
		}
		else
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			print("Down Arrow was pressed");
			max=guess;
			NextGuess();
		}
		else
		if (Input.GetKeyDown(KeyCode.Return))
		{
			print("you won the game");
			StartGame();
		}
		
	}
}
