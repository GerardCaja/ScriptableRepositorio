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

    public void InspectItem()
    {
        if(slotItem != null)
        {
            inspectionImage.sprite = slotItem.weaponsSprite;
            inspecionName.text = slotItem.weaponsName;
            inspectionPrice.text = slotItem.itemPrice.ToString();
            inspectionDescription.text = slotItem.itemDescription;

            inspectionWindow.SetActive(true);
        }
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
