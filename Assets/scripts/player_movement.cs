using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float speed = 10.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
         float horizontalInput= Input.GetAxis("Horizontal");
         float verticalInput= Input.GetAxis("Vertical");
         
        Vector3 movementDirection = new Vector3(horizontalInput, 0 , verticalInput);
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
