﻿using UnityEngine;
using System.Collections;

namespace CakeRaid{
	public class Button : MonoBehaviour {
		// Use this for initialization
		void Start () {
		
		}
		
		// Update is called once per frame
		void Update () {
		
		}

		void OnMouseDown(){
			Application.LoadLevel("level1");
		}
	}
}