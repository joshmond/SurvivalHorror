using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemInformation : MonoBehaviour 
{
	private PlayerInventory inventory;
	private Text itemName;
	private Text itemDescription;
	private Text itemType;
	private int number;

	// Use this for initialization
	void Awake () 
	{
		inventory = GameObject.FindGameObjectWithTag ("UI").transform.GetChild (1).GetComponent<PlayerInventory> ();
		number = inventory.slotNum;
	}

	void Start()
	{
		itemName = GameObject.FindGameObjectWithTag ("Item Name").transform.GetChild (0).GetComponent<Text> ();
		itemDescription = GameObject.FindGameObjectWithTag ("Item Description").transform.GetChild (0).GetComponent<Text> ();
		itemType = GameObject.FindGameObjectWithTag ("Item Type").transform.GetChild (0).GetComponent<Text> ();
	}
	
	public void UpdateInformation(int index)
	{
		itemName.text = inventory.items [index].itemName.ToString();
		itemDescription.text = inventory.items [index].itemDescription.ToString();
		itemType.text = inventory.items [index].itemType.ToString();
	}

	public void DestroyInformation()
	{
		itemName.text = "";
		itemDescription.text = "";
		itemType.text = "";
	}
}
