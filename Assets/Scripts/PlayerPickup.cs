using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public float pickupRange = 3f;           // Distanza massima per prendere l'oggetto
    public Transform holdParent;             // Crea un oggetto vuoto davanti alla camera e trascinalo qui
    private InteractableItem heldItem;
    
    public void PremutoPick()
    {
        if (heldItem == null)
        {
            TryPickup();
        }
        else
        {
            DropItem();
        }
    }

    void TryPickup()
    {
        RaycastHit hit;
        // Lancia un raggio dal centro della telecamera
        if (Physics.Raycast(transform.position, transform.forward, out hit, pickupRange))
        {
            InteractableItem item = hit.collider.GetComponent<InteractableItem>();
            if (item != null)
            {
                heldItem = item;
                heldItem.PickUp(holdParent);
            }
        }
    }

    void DropItem()
    {
        heldItem.Drop();
        heldItem = null;
    }
}
