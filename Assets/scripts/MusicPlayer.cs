using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetVolume(50);
    }

    void PlaySong(string songName = "Fallen Down")
    {
      if (Input.GetKeyDown(KeyCode.P))
      {
        //play song
      }
    }
    
    void StopSong()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //stop song
        }

    }

    void SetVolume(float volume = 50)
    {
     if (Input.GetKeyDown(KeyCode.U))
     {
      volume = volume + 10;
      Debug.Log("volume =" + volume);
     }
     else if (Input.GetKeyDown(KeyCode.D))
     {
        volume = volume - 10;
        Debug.Log("volume = " + volume);
     }
     else if (volume > 100)
     {
        volume = 100;
        Debug.Log("Max volume");
     }
     else if (volume < 0)
     {
        volume = 0;
        Debug.Log("Sound off");
     }
    }
}
