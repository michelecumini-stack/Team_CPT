using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void PickUp(Transform holdParent)
    {
        rb.isKinematic = true; // Disabilita la fisica per non farlo cadere
        transform.SetParent(holdParent);
        transform.localPosition = Vector3.zero; // Lo centra nel punto di presa
        transform.localRotation = Quaternion.identity;
    }

    public void Drop()
    {
        rb.isKinematic = false; // Riattiva la fisica
        transform.SetParent(null);
    }
}
