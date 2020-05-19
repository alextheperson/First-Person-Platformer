using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{   
    public AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        //InitPlayer.maxScore = InitPlayer.maxScore + 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        InitPlayer.score = InitPlayer.score + 1;
        audioData = GameObject.Find ("Main Camera").GetComponent<AudioSource>();
        audioData.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
