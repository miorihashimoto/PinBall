using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private GameObject scoreText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {    

    }

       void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="SmallStarTag")
        {
           score += 100;
        }

        if(other.gameObject.tag=="LargeStarTag")
        {
            score += 250;
        }

        if(other.gameObject.tag=="SmallCloudTag")
        {
           score += 200;
        }

        if(other.gameObject.tag=="LargeCloudTag")
        {
            score += 300;
        }
        this.scoreText.GetComponent<Text>().text = "Score "+score.ToString();

    }
}
