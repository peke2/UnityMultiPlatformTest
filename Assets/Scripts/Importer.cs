using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Runtime.InteropServices;

public class Importer : MonoBehaviour {

	[DllImport ("packed")]
	private static extern IntPtr GetToken();

	// Use this for initialization
	void Start () {
		IntPtr ptr = GetToken();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
