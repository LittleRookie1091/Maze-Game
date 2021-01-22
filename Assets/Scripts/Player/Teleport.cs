using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject spot;
    
    public GameObject[] allSpots;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter");
        spot = other.gameObject;
        string tagger = spot.tag;
        allSpots = GameObject.FindGameObjectsWithTag(tagger);
        foreach (GameObject spoty in allSpots)
        {
            if(spot != spoty)
            {
                Vector3 position = spoty.transform.position;
                position.y = position.y - 2;
                this.transform.position= position;
                break;
            }

        }
    }
}
