using UnityEngine;

public class CoinVerdwijn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            int score = 0;
            Debug.Log($"{score}");
            score = score + 1;
            Debug.Log($"{score}");
        }
    }
}
