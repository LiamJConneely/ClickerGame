using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeUp : MonoBehaviour {

	private float now = 1f; 
	private float score = 0; 
	public Text scoreLabel; 
	public float scoreWaitTime;
	float countTime;


	void Start(){
		scoreLabel.text = score.ToString();
	}

	void Update(){
		
//		InvokeRepeating ("AddToScore", 1.0f, 1.0f);
		if (Time.time-countTime >= scoreWaitTime ) {
			StartCoroutine ("AddToScore");
			countTime = Time.time;
		}
	}

	IEnumerator AddToScore(){
//		now += Time.deltaTime;
		yield return new WaitForSeconds (1);
//		if (now >=1f) {
			score = score + 1f; 
			scoreLabel.text = score.ToString();

//			now -= 1f;
//		}

	
	}
}
