using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    bool IsPlaying = true;
    string currentSong = "none";
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetVolume(50);
    }

    // Update is called once per frame
    void Update()
     {
     if (Input.GetKeyDown(KeyCode.Alpha1))
     {
        SetVolume(10);
      
     }
     if(Input.GetKeyDown(KeyCode.Alpha2)){

        SetVolume(20);
     }
     if(Input.GetKeyDown(KeyCode.P)){
        PlaySong("hahahah");

     }

        PlaySong();
        StopSong();

        
        
        if (Input.GetKeyDown(KeyCode.I)){
         if (IsPlaying == true){
            Debug.Log("Is playing: True");
         }
         if (IsPlaying == false){
            Debug.Log("Is playing: False");
         }}
    }

    void PlaySong(string songName = "Fallen down")
    {
    
        Debug.Log("Playing song:" + songName);
        currentSong = songName;
        IsPlaying = true;

        string GetCurrentSong = songName;

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Current song: " + GetCurrentSong);
        }

    }
    
    void StopSong()
    {
        
        Debug.Log("Song stopped");
        IsPlaying = false;
    

    }

    void SetVolume(float volume){
        Debug.Log("Volume is now" + volume);

        if (Input.GetKeyDown(KeyCode.D))
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
