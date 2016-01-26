using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	public Item item;
	public int slotNumber;

	private Image itemIcon;
	private PlayerInventory inventory;
	private UIManager manager;
	private ItemInformation itemInformation;



	void Awake()
	{
		itemIcon = gameObject.transform.GetChild (0).GetComponent<Image> ();
		inventory = GameObject.FindGameObjectWithTag ("UI").transform.GetChild (1).GetComponent<PlayerInventory> ();
		manager = GameObject.FindGameObjectWithTag ("UI").GetComponent<UIManager> ();
		itemInformation = GameObject.FindGameObjectWithTag ("UI").transform.GetChild (1).GetChild (0).GetComponent<ItemInformation> ();
	}
	
	void Update () 
	{
		if(inventory.items[slotNumber].itemName != null)
		{
			itemIcon.enabled = true;
			itemIcon.sprite = inventory.items[slotNumber].itemIcon;
		}
		else
		{
			itemIcon.enabled = false;
		}
	}
	

	public void OnPointerEnter (PointerEventData eventData)
	{
		if(inventory.items[slotNumber].itemName != null)
		{
			manager.ShowItemInformation();
			itemInformation.UpdateInformation(slotNumber);
		}
	}
	

	public void OnPointerExit (PointerEventData eventData)
	{
		manager.HideItemInformation();
		itemInformation.DestroyInformation();
	}
}
