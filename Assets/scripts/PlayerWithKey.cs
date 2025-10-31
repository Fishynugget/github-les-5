using UnityEngine;

public class PlayerWithKey : MonoBehaviour
{
    public float speed = 10.0f;
    bool HasKey = false;
    GameObject Key;
    GameObject Door;
    GameObject Wall;
    GameObject Player;
    Collider Capsule;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Key = GameObject.FindWithTag("Key");
        Door = GameObject.FindWithTag("Door");
        Wall = GameObject.FindWithTag("Wall");
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float Jump = Input.GetAxis("Jump");

        
        if (HasKey == true && Input.GetKeyDown(KeyCode.E))
        {
          Destroy(Wall);
          Debug.Log("Door opened!");
        }
        

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movementDirection * speed * Time.deltaTime);
        Vector3 movementJump = new Vector3(0, Jump, 0);
        transform.Translate(movementJump * speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider Capsule)
    {
        if (Capsule.CompareTag("Key"))
        {
            Destroy(Key);
            HasKey = true;
            Debug.Log("Player has key!");
        }

        if (Capsule.CompareTag("Door") && HasKey == true)
        {
            Debug.Log("Press E to open the door");
        }

       
    }

}
