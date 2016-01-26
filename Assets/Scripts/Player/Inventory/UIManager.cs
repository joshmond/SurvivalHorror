using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour 
{
	public GameObject itemInformation;

	void Start()
	{
		itemInformation.SetActive (false);
	}

	public void ShowItemInformation()
	{
		itemInformation.SetActive (true);
	}

	public void HideItemInformation()
	{
		itemInformation.SetActive (false);
	}
}
