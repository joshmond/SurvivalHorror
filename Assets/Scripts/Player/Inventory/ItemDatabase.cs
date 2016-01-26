using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ItemDatabase : MonoBehaviour 
{
	public List<Item> items = new List<Item>();

	void Start () 
	{
		items.Add (new Item (0, "Gun", "This is a pistol", Items.GUN));
		items.Add (new Item (1, "Gun", "This is a pistol", Items.GUN));
		items.Add (new Item (2, "Bullet", "This is a Ammo", Items.BULLETS));
		items.Add (new Item (3, "Health", "This is a Health", Items.HEALTH));
	}
}