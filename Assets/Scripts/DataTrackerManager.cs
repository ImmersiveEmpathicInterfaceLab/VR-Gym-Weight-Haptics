using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTrackerManager : MonoBehaviour
{
    public CSV_Test[] trackers;
    public GameObject endMessage;
    private float timeRemaining = 30f;
    // Start is called before the first frame update
    void Start()
    {
        endMessage.SetActive(false);
        //Right hand = 0, Left hand = 1
        if (PlayerPrefs.GetInt("DomHand") == 0)
        {
            trackers[0].enabled = true;
            trackers[1].enabled = false;
        }
        else
        {
            trackers[0].enabled = false;
            trackers[1].enabled = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if ((timeRemaining -= Time.deltaTime) <= 0)
        {
            for (int i = 0; i < trackers.Length; i++)
                trackers[i].enabled = false;

            endMessage.SetActive(true);
        }
    }
}
