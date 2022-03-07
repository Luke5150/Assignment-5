using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text ScoreText;
    public int score;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Gems: " + score + "/32";
    }
}
