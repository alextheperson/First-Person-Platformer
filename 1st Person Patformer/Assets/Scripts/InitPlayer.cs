using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitPlayer : MonoBehaviour
{
    public static int score = 0;
    public static int totalScore = 0;
    public /*static*/ int maxScore = 1;

    public Text txt;

    // Start is called before the first frame update
    void Start()
    {

        score = 0;
        //maxScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + score.ToString() + "/" + maxScore.ToString();
    }
}
