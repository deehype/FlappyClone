using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D colision)
    {
        Score.score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
