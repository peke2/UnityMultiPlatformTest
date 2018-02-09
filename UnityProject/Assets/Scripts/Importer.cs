using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Runtime.InteropServices;

public class Importer : MonoBehaviour {

	//[DllImport ("packed")]
	[DllImport ("PluginSample")]	//64bit版ならDLL Not Foundは出ない
	private static extern IntPtr GetToken();

	[DllImport ("PluginSample")]
	private static extern IntPtr Say();

	// Use this for initialization
	void Start () {
		IntPtr ptr = GetToken();
		byte[] buff = new byte[16];
		Marshal.Copy(ptr, buff, 0,16);

		ptr = Say();
		string message = Marshal.PtrToStringAnsi(ptr);
		Debug.Log(message);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
