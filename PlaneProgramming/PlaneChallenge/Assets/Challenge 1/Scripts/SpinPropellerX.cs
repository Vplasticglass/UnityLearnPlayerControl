using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float spinSpeed = 50.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(5 * spinSpeed * Time.deltaTime * Vector3.forward);
    }
}
