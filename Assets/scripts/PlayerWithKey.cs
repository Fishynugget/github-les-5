using UnityEngine;

public class PlayerWithKey : MonoBehaviour
{
    public float speed = 10.0f;
    bool HasKey = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float Jump = Input.GetAxis("Jump");



        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movementDirection * speed * Time.deltaTime);
        Vector3 movementJump = new Vector3(0, Jump, 0);
        transform.Translate(movementJump * speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            HasKey = true;
            Debug.Log("Player has key!");
        }
    }
}
