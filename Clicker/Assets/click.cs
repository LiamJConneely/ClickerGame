using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class click : MonoBehaviour {
	public Button picklebutton;
	public Image face;
	public Sprite opened, closed;
	public bool photo;
	public Text falsepromisescore;
	public Text students;
	public Text lecturers;
	public Text buildings;
	public Text rooms;
	public Text computers;
	public float falsepromises;
	public int increase;
	private float now = 1f; 
	private float score = 0; 
	public float scoreWaitTime;
	float countTime;
	public float student;
	public float timething;
	public float mmorty;
	public float lect;
	public float rrooms;
	public float build;
	public float stunumber;
	public float comnumbers;
	public float roomumbers;
	public float lectnumbers;
	public float buildingnumbers;
	public ParticleSystem compart, stupart, baspart, roompar, buspart;

	bool updates = false;

	// Use this for initialization
	void Start () {
		//Button btn = picklebutton.GetComponent<Button>();
		picklebutton.onClick.AddListener(TaskOnClick);
		
		falsepromises = 0;
		increase = 1;
		Text txt = falsepromisescore.GetComponent<Text> ();

		student = 15;
		mmorty = 100;
		lect = 1100;
		rrooms = 1200;
		build = 130000;
		timething = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
		

		//		InvokeRepeating ("AddToScore", 1.0f, 1.0f);
		if (Time.time-countTime >= scoreWaitTime && updates == true  ) {
			StartCoroutine ("AddToScore");
			countTime = Time.time;
		}

		
	}

	void TaskOnClick () {


		Debug.Log(falsepromises);
		falsepromises += 1f;
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
		if (falsepromises >= student) {
			student += 3;
			updates = true;
			falsepromises -= 15;
			timething += 0.01f;
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

		}


	}

	IEnumerator AddToScore(){
		//		now += Time.deltaTime;
		if (updates == true) {
			yield return new WaitForSeconds (1);
			//		if (now >=1f) {
			falsepromises = falsepromises + timething;
			falsepromisescore.text = "" + falsepromises;
		}
		//			now -= 1f;
		//		}


	}
}
