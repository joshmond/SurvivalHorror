using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemInteraction : MonoBehaviour 
{
	public GameObject item;

	private float distance;
	private string itemName;
	private bool inRange;
	private Text message;
	private PlayerInventory inventory;
	private bool hasPickedUp;
	private Brightness brightness;

	void Awake()
	{
		message = GameObject.FindGameObjectWithTag ("UI").transform.GetChild(0).GetComponent<Text> ();
		inventory = GameObject.FindGameObjectWithTag ("UI").transform.GetChild (1).GetComponent<PlayerInventory> ();
		brightness = GameObject.FindGameObjectWithTag ("Light").GetComponent<Brightness> ();
	}
	
	void Start () 
	{
		distance = 1.0f;
		itemName = item.name;
		inRange = false;
		message.text = "";
		hasPickedUp = false;
	}

	void Update () 
	{
		if(brightness.isOn)
		{
			if(item != null)
			{
				item.SetActive(true);
				Interact();
			}
		}
		else
		{
			item.SetActive(false);
			message.text = "";
		}

	}

	private void ShowMessage()
	{
		if(inRange)
		{
			message.text = "Pick up " + itemName + "?";
		}
	}

	private void PickUpItem(int index)
	{
		inventory.AddItem (index);
		Destroy (item.gameObject);
		hasPickedUp = true;
	}

	private void Interact()
	{
		if(!hasPickedUp)
		{
			if(Vector3.Distance(transform.position, item.transform.position) < distance)
			{
				inRange = true;
				hasPickedUp = false;
				
				ShowMessage();
				
				if(Input.GetButtonDown("Pickup") && inRange)
				{
					PickUpItem(3);
					message.text = "";
				}
			}
			else
			{
				message.text = "";
			}
		}
	}
}
