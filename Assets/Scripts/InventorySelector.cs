using UnityEngine;

public class InventorySelector : MonoBehaviour
{
    public RectTransform selection;

    public RectTransform lighterSlot;
    public RectTransform candleSlot;
    public RectTransform bookSlot;
    public RectTransform keySlot;
    public EquipmentManager equipmentManager;
    public InventoryManager inventoryManager;
    public InventoryUI inventoryUI;

    private int currentSlot = -1;

    void Start()
    {
        RefreshSelection();
    }

    void Update()
    {
        if (!inventoryUI.inventoryOpen)
            return;

        if (!selection.gameObject.activeSelf)
            return;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            EquipSelectedItem();
        }
    }

    public void RefreshSelection()
    {
        if (!inventoryManager.hasLighter &&
            !inventoryManager.hasCandle &&
            !inventoryManager.hasBook &&
            !inventoryManager.hasKey)
        {
            selection.gameObject.SetActive(false);
            currentSlot = -1;
            return;
        }

        selection.gameObject.SetActive(true);

        if (currentSlot == -1)
        {
            if (inventoryManager.hasLighter)
                currentSlot = 0;
            else if (inventoryManager.hasCandle)
                currentSlot = 1;
            else if (inventoryManager.hasBook)
                currentSlot = 2;
            else if (inventoryManager.hasKey)
                currentSlot = 3;
        }

        UpdateSelection();
    }

    void MoveRight()
    {
        for (int i = currentSlot + 1; i <= 3; i++)
        {
            if (IsUnlocked(i))
            {
                currentSlot = i;
                UpdateSelection();
                return;
            }
        }
    }

    void MoveLeft()
    {
        for (int i = currentSlot - 1; i >= 0; i--)
        {
            if (IsUnlocked(i))
            {
                currentSlot = i;
                UpdateSelection();
                return;
            }
        }
    }

    bool IsUnlocked(int slot)
    {
        switch (slot)
        {
            case 0:
                return inventoryManager.hasLighter;

            case 1:
                return inventoryManager.hasCandle;

            case 2:
                return inventoryManager.hasBook;

            case 3:
                return inventoryManager.hasKey;
        }

        return false;
    }

    void UpdateSelection()
    {
        switch (currentSlot)
        {
            case 0:
                selection.position = lighterSlot.position;
                break;

            case 1:
                selection.position = candleSlot.position;
                break;

            case 2:
                selection.position = bookSlot.position;
                break;

            case 3:
                selection.position = keySlot.position;
                break;
        }
    }
    void EquipSelectedItem()
    {
        switch (currentSlot)
        {
            case 0:
                if (inventoryManager.hasLighter)
                    equipmentManager.EquipLighter();
                break;

            case 1:
                if (inventoryManager.hasCandle)
                    equipmentManager.EquipCandle();
                break;

            case 2:
                if (inventoryManager.hasBook)
                {
                    // Nothing for now
                }
                break;

            case 3:
                if (inventoryManager.hasKey)
                    equipmentManager.EquipKey();
                break;
        }
    }
}