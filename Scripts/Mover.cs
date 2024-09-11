using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * _moveSpeed;
    }
}
