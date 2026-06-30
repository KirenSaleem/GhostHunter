using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    public GameObject lighterInHand;
    public GameObject candleInHand;
    public GameObject keyInHand;
    public bool lighterEquipped = false;
    public bool candleEquipped = false;
    public bool keyEquipped = false;

    void Start()
    {
        UnequipAll();
    }

    public void EquipLighter()
    {
        UnequipAll();
        lighterInHand.SetActive(true);
        lighterEquipped = true;
    }

    public void EquipCandle()
    {
        UnequipAll();

        candleInHand.SetActive(true);

        candleEquipped = true;
    }
    public void EquipKey()
    {
        UnequipAll();
        keyEquipped = true;
        keyInHand.SetActive(true);
    }

    public void UnequipAll()
    {
        lighterInHand.SetActive(false);
        candleInHand.SetActive(false);
        keyInHand.SetActive(false);

        lighterEquipped = false;
        candleEquipped = false;
        keyEquipped=false;
    }
}