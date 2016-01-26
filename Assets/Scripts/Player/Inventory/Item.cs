using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Items
{
	GUN,
	HEALTH,
	BULLETS
}

public class Item
{
	public int itemID;
	public string itemName;
	public string itemDescription;
	public Items itemType;
	public Sprite itemIcon;

	public Item(int id, string name, string description, Items type)
	{
		itemID = id;
		itemName = name;
		itemDescription = description;
		itemType = type;
		itemIcon = Resources.Load<Sprite> ("" + name);
	}

	public Item()
	{

	}

}
