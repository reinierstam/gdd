using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {
	
	public Text countText;
	public float score;
	private float startTime;
	
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		// 10 must be a get current time method
		countText.text = "Score:" +  Time.frameCount;
	}
}
