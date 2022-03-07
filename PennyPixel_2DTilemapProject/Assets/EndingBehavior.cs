/*
 * (Luke Hensley)
 * (Assignment 5A)
 * (Checks if the player has reached the end)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingBehavior : MonoBehaviour
{
    public Text winText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            winText.gameObject.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
