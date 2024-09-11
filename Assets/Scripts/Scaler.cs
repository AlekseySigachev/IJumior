using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _growingSpeed;

    private void Update()
    {
        transform.localScale += _growingSpeed * Time.deltaTime;
    }
}
