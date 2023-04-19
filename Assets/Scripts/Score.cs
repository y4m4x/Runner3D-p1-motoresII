using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scorenumber;
    public float scoreSuma;
    
    
    // Start is called before the first frame update
    void Start()
    {
        scorenumber = 0f;
        scoreSuma = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Points: " + (int)scorenumber;
        scorenumber += scoreSuma * Time.deltaTime;
    }
}
