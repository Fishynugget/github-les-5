using UnityEngine;

public class coin : MonoBehaviour
{
    
        public float rotateSpeed = 90.0f; // graden per seconde
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
}
