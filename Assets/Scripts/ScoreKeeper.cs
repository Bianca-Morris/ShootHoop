using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public int score; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) 
	{
		score += 1;
		print ("score: " + score);
	}
}
