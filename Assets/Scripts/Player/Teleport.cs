using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject spot;
    public GameObject white;
    public GameObject black;
    public GameObject[] allSpots;


    void Start()
    {
        Vector3 coord = new Vector3(-100, -100, -100);
        white = Instantiate(white, coord, Quaternion.identity);
        black = Instantiate(black, coord, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log("OnTriggerEnter");
        spot = other.gameObject;
        string tagger = spot.tag;
        allSpots = GameObject.FindGameObjectsWithTag(tagger);
        foreach (GameObject spoty in allSpots)
        {
            if(spot != spoty)
            {
                Vector3 cover = this.transform.position;
                cover.z = cover.z - 2;
                StartCoroutine(ExampleCoroutine(1, cover));

                Vector3 position = spoty.transform.position;
                position.y = position.y-2;
                this.transform.position= position;
                break;
            }

        }
    }

    IEnumerator ExampleCoroutine(float num, Vector3 cover)
    {
        //Print the time of when the function is first called.
       // Debug.Log("Started Coroutine at timestamp : " + Time.time);
        //Debug.Log(cover);
        black.transform.position = cover;
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(num);
        Vector3 coord = new Vector3(-100, -100, -100);
        black.transform.position = coord;
        //After we have waited 5 seconds print the time again.
       // Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
