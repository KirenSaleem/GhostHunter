
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject lighterCover;
    public GameObject candleCover;
    public GameObject bookCover;
    public GameObject keyCover;

    public bool hasLighter = false;
    public bool hasCandle = false;
    public bool hasBook = false;
    public bool hasKey = false;
    public int candlesLit = 0;
    private InventorySelector inventorySelector;
    public ClueManager clueManager;
    public bool debugStartWithLighter = false;
    public bool debugStartWithcandle = false;
    public bool debugStartWithKey = false;
    private void Start()
    {
        lighterCover.SetActive(true);
        candleCover.SetActive(true);
        bookCover.SetActive(true);
        keyCover.SetActive(true);

        inventorySelector = GetComponent<InventorySelector>();
        if (debugStartWithKey)
        {
            CollectKey();
        }
        if (debugStartWithcandle)
        {
            CollectCandle();
        }
        if (debugStartWithLighter)
        {
            CollectLighter();
        }
    }

    public void CollectLighter()
    {
        hasLighter = true;
        lighterCover.SetActive(false);

        inventorySelector.RefreshSelection();
        
    }

    public void CollectCandle()
    {
        hasCandle = true;
        candleCover.SetActive(false);

        inventorySelector.RefreshSelection();
    }

    public void CollectBook()
    {
        hasBook = true;
        bookCover.SetActive(false);
        clueManager.ShowClue(4);
        inventorySelector.RefreshSelection();
    }

    public void CollectKey()
    {
        hasKey = true;
        keyCover.SetActive(false);
        clueManager.ShowClue(3);
        inventorySelector.RefreshSelection();
    }
    public void CandleLit()
    {
        candlesLit++;

        if (candlesLit >= 3)
        {
            CollectCandle();
            clueManager.ShowClue(3);
            Debug.Log("Lit Candle Unlocked!");
        }
    }
}