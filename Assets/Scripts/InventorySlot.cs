using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public ScriptableItem slotItem;
    public int slotNumber;

    public GameObject inspectionWindow;
    public Image inspectionImage;
    public Text inspecionName;
    public Text inspectionPrice;
    public Text inspectionDescription;

    public Button deleteButton;
    public Button closeButton;

    public void InspectItem()
    {
        if(slotItem != null && inspectionWindow.activeInHierarchy == false)
        {
            deleteButton.onClick.AddListener(RemoveItem);
            closeButton.onClick.AddListener(CloseInspectionWindow);

            inspectionImage.sprite = slotItem.itemSprite;
            inspecionName.text = slotItem.itemName;
            inspectionPrice.text = slotItem.itemPrice.ToString();
            inspectionDescription.text = slotItem.itemDescription;

            inspectionWindow.SetActive(true);
        }
    }


    public void RemoveItem()
    {
        if(InventoryManager.instance.weapons[slotNumber]!= null)
        {
            InventoryManager.instance.weapons[slotNumber] = null;
            InventoryManager.instance.weaponsNames[slotNumber].text = "Empty";
            InventoryManager.instance.weaponsSprites[slotNumber].sprite = null;
        }

        slotItem = null;

        deleteButton.onClick.RemoveListener(RemoveItem);

        inspectionWindow.SetActive(false);
    }

    public void CloseInspectionWindow()
    {
        deleteButton.onClick.RemoveListener(RemoveItem);

        inspectionWindow.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
