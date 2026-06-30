using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public bool inventoryOpen = false;

    void Start()
    {
        inventoryPanel.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryOpen = !inventoryOpen;
            inventoryPanel.SetActive(inventoryOpen);
        }
    }
}