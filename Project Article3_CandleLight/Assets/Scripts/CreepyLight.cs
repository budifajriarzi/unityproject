﻿using UnityEngine;
using System.Collections;

public class CreepyLight : MonoBehaviour {

	public float MinIntensity = 0f;
	public float MaxIntensity = 1f;
	public float MinInterval = 0f;
	public float MaxInterval = 1f;
	public float AdditionalRandom = 0;

	private float timer;
	// Use this for initialization
	void Start () {
		timer = Time.time;
		StartCoroutine (RandomLightEverySeconds (MinInterval, MaxInterval));
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator RandomLightEverySeconds(float minInterval, float maxInterval) {
		yield return new WaitForSeconds (Random.Range(minInterval, maxInterval));
		light.intensity = Random.Range (MinIntensity, MaxIntensity);
		for (int i = 0; i < AdditionalRandom; i++) {
			yield return new WaitForSeconds (0.01f);
			light.intensity = Random.Range (MinIntensity, MaxIntensity);
		}
		StartCoroutine(RandomLightEverySeconds (MinInterval, MaxInterval));
	}


	void LateUpdate() {
//		if(Time.time > timer + 1) {
//			timer +=1;
//			Debug.Log("timer: " + timer);
//		}
//		light.intensity = Random.Range (minIntensity, maxIntensity);
	}
}
