using UnityEngine;

public class RandomItem : MonoBehaviour
{
    [SerializeField] private GameObject[] items;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.Escape))PrintAllItems();
    }

    private void PrintRandomItem()
    {
       Debug.Log(items[Random.Range(0, 9)]);
    }

    private void PrintAllItems()
    {
       for (int i = 0; i < items.Length; i++)
       {
        Debug.Log(items[i]);
       }
      
    }
}
