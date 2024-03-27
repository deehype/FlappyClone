using System;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "BestScore : " + Score.bestScore.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
