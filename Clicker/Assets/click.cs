using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class click : MonoBehaviour {
	public Button picklebutton;
	public Image face;
	public Sprite opened, closed;

	public Text falsepromisescore;
	public Text students;
	public Text lecturers;
	public Text buildings;
	public Text rooms;
	public Text computers;
	public int falsepromises;
	


	public int scoreWaitTime;
	int countTime;
	public int student;
	public int timething;
	public int mmorty;
	public int lect;
	public int rrooms;
	public int build;
	public int stunumber;
	public int comnumbers;
	public int roomumbers;
	public int lectnumbers;
	public int buildingnumbers;
	public ParticleSystem compart, stupart, baspart, roompar, buspart;

	bool updates = false;

	// Use this for initialization
	void Start () {
		//Button btn = picklebutton.GetComponent<Button>();
		picklebutton.onClick.AddListener(TaskOnClick);
		
		falsepromises = 0;
		
		Text txt = falsepromisescore.GetComponent<Text> ();

		student = 15;
		mmorty = 100;
		lect = 1100;
		rrooms = 1200;
		build = 130000;
		timething = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		

		//		InvokeRepeating ("AddToScore", 1.0f, 1.0f);
		

		
	}

	void TaskOnClick () {


		Debug.Log(falsepromises);
		falsepromises += 1;
		falsepromisescore.text = "" + falsepromises;
		
		if (face.sprite == closed)
		{
			face.sprite = opened;

		}else if (face.sprite == opened)
		{

			face.sprite = closed;
		}

	}

	void GoDown ()
	{
		if (falsepromises >= student)
		{
			StartCoroutine(AddToScore());
			student += 3;
			updates = true;
			falsepromises -= student;
			timething += 1;
			stunumber += 1;
			students.text = "" + stunumber;
			stupart.Play();
			
		}


	}



	void Morty()
	{
		if (falsepromises >= mmorty) {
			mmorty += 30;
			timething += 1;
			falsepromises -= 100;
			comnumbers += 1;
			computers.text = " " + comnumbers;
			compart.Play();
			updates = true;
		}


	}
	void Lecturers()
	{
		if (falsepromises >= lect) {
			lect += 500;
			timething += 8;
			falsepromises -= 1100;
			lectnumbers += 1;
			lecturers.text = " " + lectnumbers;
			baspart.Play();
			updates = true;
		}


	}
	void Rooms()
	{
		if (falsepromises >= rrooms) {
			rrooms += 3000;
			timething += 47;
			falsepromises -= 12000;
			roomumbers += 1;
			roompar.Play();
			rooms.text = " " + roomumbers;
			updates = true;

		}


	}
	void Buildings()
	{
		if (falsepromises >= build) {
			build += 100000;
			timething += 260;
			falsepromises -= 130000;
			buildingnumbers += 1;
			buspart.Play();
			buildings.text = " " + buildingnumbers;
			updates = true;

		}


	}

	IEnumerator AddToScore(){
	
		
			yield return new WaitForSeconds (1);
			falsepromises = falsepromises += timething;
		
		


	}
}
