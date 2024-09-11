using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        transform.position  = new Vector3(transform.position.x + _moveSpeed, transform.position.y, transform.position.z);
    }
}
