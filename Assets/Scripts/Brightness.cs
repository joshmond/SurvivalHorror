using UnityEngine;
using System.Collections;

public class Brightness : MonoBehaviour 
{
	public bool isOn;

	private Light brightness;
	// Use this for initialization
	void Start () 
	{
		isOn = true;
		brightness = GameObject.FindGameObjectWithTag ("Light").GetComponent<Light> ();
	}

	public void IncreaseBrightness()
	{
		brightness.enabled = true;
		isOn = true;
	}

	public void DecreaseBrightness()
	{
		brightness.enabled = false;
		isOn = false;
	}
}
