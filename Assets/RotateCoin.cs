using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float rotateSpeed = 100f;

    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);

        
    }
}