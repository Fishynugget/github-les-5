using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    int score = 0;
    float speed = 10.0f;
    Collider Capsule;
    GameObject Coin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Coin = GameObject.FindWithTag("coin");
        Debug.Log($"Score = {score}");
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

    void OnTriggerEnter(Collider Capsule)
    {
        if (Capsule.CompareTag("coin"))
        {
            Destroy(Coin);
            score = score + 1;
            Debug.Log($"{score}");
        }
    }
}
