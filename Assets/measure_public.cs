﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class measure_public : MonoBehaviour {

	public Text test_string;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void OnMeasure(){
		//スタート時間
		float _startTime = Time.realtimeSinceStartup;

		for (int i =0; i < 1000000; i++ ){
			test_string.text = "集計" + i;

		}

		//終了時間
		float _endTime = Time.realtimeSinceStartup;

		Debug.Log(_endTime - _startTime);


	}
}
