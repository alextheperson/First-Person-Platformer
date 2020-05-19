using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    public int currentScene = 0;
    public AudioSource audioData;
    public bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("level" + (currentScene+1).ToString());
    }

    void Update()
    {
        if (InitPlayer.score == GameObject.Find ("Main Camera").GetComponent<InitPlayer>().maxScore && !played){
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            played = true;
        }   
    }
}
