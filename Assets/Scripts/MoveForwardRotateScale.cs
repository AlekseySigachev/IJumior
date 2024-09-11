using UnityEngine;

public class MoveForwardRotateScale : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Vector3 _growingSpeed;

    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime * _moveSpeed;
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        transform.localScale += _growingSpeed * Time.deltaTime;
    }
}
