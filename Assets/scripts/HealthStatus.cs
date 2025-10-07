using UnityEngine;

public class HealthStatus : MonoBehaviour
{
     int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.H)){
            health = health + 10;
            Debug.Log(health);
        }
        else if (Input.GetKeyDown(KeyCode.J)){
           health = health - 10;
           Debug.Log(health);
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            if (health > 80) {
         Debug.Log("Exellent health!");
         }
         else if (health < 80 && health > 50){
            Debug.Log("Good health!");
         }
         else if (health < 50 && health > 20){
            Debug.Log("Warning: Low health!");
         }
         else {
            Debug.Log("Critical: Very low health!");
         }
        }
    }
}
