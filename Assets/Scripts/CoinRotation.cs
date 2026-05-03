using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float _rotationSpeed = 120f;
    private void Update()
    {
        transform.Rotate(Vector3.up, _rotationSpeed*Time.deltaTime );
    }
}

    


