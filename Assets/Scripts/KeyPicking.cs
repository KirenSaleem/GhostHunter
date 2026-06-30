

using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public InventoryManager inventoryManager;
    

    private bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.P) && inventoryManager.hasBook)
        {
            inventoryManager.CollectKey();

            Destroy(gameObject);

            Debug.Log("Rusty Key Collected!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            Debug.Log("Press P to pick up the Rusty Key.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}