using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    bool IsPlaying = true;
    string songName = "Fallen Down";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetVolume();
        PlaySong();
        StopSong();

        string GetCurrentSong = songName;

        if (Input.GetKeyDown(KeyCode.C)){
            Debug.Log("Current song: " + GetCurrentSong);
        }
        
        if (Input.GetKeyDown(KeyCode.I)){
         if (IsPlaying == true){
            Debug.Log("Is playing: True");
         }
         else if (IsPlaying == false){
            Debug.Log("Is playing: False");
         }}
    }

    void PlaySong()
    {
      if (Input.GetKeyDown(KeyCode.P))
      {
        Debug.Log("Playing song:" + songName);
        IsPlaying = true;
      }
    }
    
    void StopSong()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Song stopped");
            IsPlaying = false;
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
