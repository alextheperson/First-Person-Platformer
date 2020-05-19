using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorIsLava : MonoBehaviour
{   
    public Text txt;
    public GameObject button;
    public AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other){
        txt.enabled = true;
        button.SetActive(true);
        audioData = GameObject.Find("Floor").GetComponent<AudioSource>();
        audioData.Play(0);
        GameObject.Find("Ceiling").GetComponent<AudioSource>().Pause();
        Time.timeScale = 0;
    }
}
