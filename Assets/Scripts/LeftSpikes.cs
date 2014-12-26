using UnityEngine;
using System.Collections;

public class LeftSpikes : MonoBehaviour {
	
	private bool leftCornerToShow = false;
	float side = PlayerController.Move;
	float absoluteRightPos;
	float absoluteLeftPos;
	float StarterRandom;

	void Start()
	{
		absoluteRightPos = transform.position.x;
		Destroyer ();
		absoluteLeftPos = absoluteRightPos - 0.5f;
		StarterRandom = absoluteLeftPos + 0.2f ;

	}

	void Update () {
		
		side = PlayerController.Move;
		
		if (side <= 0)
			leftCornerToShow = true;
		else if (side >= 0)		
			leftCornerToShow = false;

		
		
		if (transform.position.x <= absoluteRightPos && leftCornerToShow == true)
		{ 
			transform.Translate(Vector2.right  * Time.deltaTime * -2);

		}

		else if (transform.position.x >= absoluteLeftPos && leftCornerToShow == false)
		{ 
			transform.Translate(Vector2.right  * Time.deltaTime * 1);
			
		}

		if (transform.position.x <= StarterRandom && leftCornerToShow == false)
		{ 
			{
				Destroyer();

			}
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

	public void AbsDestroyer (){
		foreach (Transform child in transform)
			child.gameObject.SetActive(false);
		}
	
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
