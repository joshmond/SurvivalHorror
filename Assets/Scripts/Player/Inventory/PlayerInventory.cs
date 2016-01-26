using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour 
{
	public List<GameObject> slots = new List<GameObject>();
	public List<Item> items = new List<Item> ();
	public GameObject slotPrefab;
	public int numberOfSlots;
	public int maxNumberOfSlots;
	public GameObject slot;
	public int slotNum;

	private int xPosition;
	private ItemDatabase itemDatabase;

	void Awake()
	{
		itemDatabase = GameObject.FindGameObjectWithTag ("Item Database").GetComponent<ItemDatabase> ();
	}

	void Start () 
	{
		numberOfSlots = 7;
		slotNum = 0;
		xPosition = -329;

		for(int cnt = 0; cnt < numberOfSlots; cnt++)
		{
			if(numberOfSlots >= maxNumberOfSlots)
			{
				numberOfSlots = maxNumberOfSlots;
			}

			slot = (GameObject)Instantiate (slotPrefab);
			slot.GetComponent<Slot>().slotNumber = slotNum;
			slots.Add(slot);
			items.Add(new Item());
			slot.transform.parent = this.gameObject.transform;
			slot.GetComponent<RectTransform>().localPosition = new Vector3(xPosition, 0.0f, 0.0f);
			xPosition = xPosition + 105;
			slot.name = "Slot" + " " + cnt.ToString();
			slotNum++;

		}

		AddItem (0);
		AddItem (2);
		AddItem (3);
		AddItem (1);
		AddItem (0);
	}

	public void AddItem(int index)
	{
		for(int cnt = 0; cnt < itemDatabase.items.Count; cnt++)
		{
			if(itemDatabase.items[cnt].itemID == index)
			{
				Item item = itemDatabase.items[cnt];
				CheckEmptySlot(item);
				break;
			}
		}
	}

	private void CheckEmptySlot(Item item)
	{
		for(int cnt = 0; cnt < items.Count; cnt++)
		{
			if(items[cnt].itemName == null)
			{
				items[cnt] = item;
				break;
			}
		}
	}

}
