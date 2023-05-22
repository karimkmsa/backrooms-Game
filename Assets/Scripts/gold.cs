using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : MonoBehaviour
{      

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.score += 1;
            Destroy(gameObject);
        }
    }
}