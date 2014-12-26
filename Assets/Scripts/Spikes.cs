using UnityEngine;
using System.Collections;

public class Spikes : MonoBehaviour {

	// The code for LeftSpikes is quite similar
	private bool rightCornerToShow = false;
	float absoluteRightPos;
	float absoluteLeftPos;
	float StarterRandom;
	
	void Start()
	{
		absoluteLeftPos = transform.position.x;
		Destroyer ();
		absoluteRightPos = absoluteLeftPos + 0.5f;


	}

	void Update () {

		float side = PlayerController.Move;

		if (side >= 0)
			rightCornerToShow = true;
		else if (side <= 0)
		{
			rightCornerToShow = false;

		}

		if (transform.position.x >= absoluteLeftPos && rightCornerToShow == true)
		{ 
			transform.Translate(Vector2.right  * Time.deltaTime * -2);
		}
		else if (transform.position.x <= absoluteRightPos && rightCornerToShow == false)
		{ 
			transform.Translate(Vector2.right  * Time.deltaTime);

		}



	}

	private int SpikeNum;
	
	public GameObject S1;
	public GameObject S2;
	public GameObject S3;
	public GameObject S4;
	public GameObject S5;
	public GameObject S6;
	public GameObject S7;
	public GameObject S8;
	public GameObject S9;
	public GameObject S10;
	public GameObject S11;
	public GameObject S12;
	public GameObject S13;
	public GameObject S14;
	public GameObject S15;
	public GameObject S16;
	public GameObject S17;
	public GameObject S18;
	public GameObject S19;
	public GameObject S20;
	public GameObject S21;

	//Destroys ALL spikes. Used for correct respawn
	public void AbsDestroyer (){
		foreach (Transform child in transform)
			child.gameObject.SetActive(false);
	}

	//Resets the spikes during the game.
	public void Destroyer(){
		int NumOfDeployedSpikes = PlayerController.GetNumOfSpikes - 1;
		foreach (Transform child in transform)
			child.gameObject.SetActive(false);
		
		
		foreach (Transform child in transform)
		{
			if(NumOfDeployedSpikes >=0)
			{
				RandomSpikeNum();
				SpikesActivator();
				NumOfDeployedSpikes -= 1;
			}
		}

		
	}
	void SpikesActivator()
	{
		if (SpikeNum == 1)
			S1.SetActive(true);			
		else if (SpikeNum == 2)
			S2.SetActive(true);
		else if (SpikeNum == 3)
			S3.SetActive(true);
		else if (SpikeNum == 4)
			S4.SetActive(true);
		else if (SpikeNum == 5)
			S5.SetActive(true);
		else if (SpikeNum == 6)
			S6.SetActive(true);
		else if (SpikeNum == 7)
			S7.SetActive(true);
		else if (SpikeNum == 8)
			S8.SetActive(true);
		else if (SpikeNum == 9)
			S9.SetActive(true);
		else if (SpikeNum == 10)
			S10.SetActive(true);
		else if (SpikeNum == 11)
			S11.SetActive(true);
		else if (SpikeNum == 12)
			S12.SetActive(true);
		else if (SpikeNum == 13)
			S13.SetActive(true);
		else if (SpikeNum == 14)
			S14.SetActive(true);
		else if (SpikeNum == 15)
			S15.SetActive(true);
		else if (SpikeNum == 16)
			S16.SetActive(true);
		else if (SpikeNum == 17)
			S17.SetActive(true);
		else if (SpikeNum == 18)
			S18.SetActive(true);
		else if (SpikeNum == 19)
			S19.SetActive(true);
		else if (SpikeNum == 20)
			S20.SetActive(true);
		else if (SpikeNum == 21)
			S21.SetActive(true);
	}
	void RandomSpikeNum()
	{
		SpikeNum = (int)Random.Range (1.0f, 21.0f);

	}

}
