using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBEMessage : MonoBehaviour
{
    private float onTimer, offTimer;
    public GameObject PBEMsg;
    // Start is called before the first frame update
    void Start()
    {
        PBEMsg.SetActive(false);
        onTimer = Time.time + 5f;
        offTimer = Time.time + 6.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= onTimer)
        {
            onTimer = Time.time + 5f;
            PBEMsg.SetActive(true);
        }

        if (Time.time >= offTimer)
        {
            offTimer = Time.time + 5f;
            PBEMsg.SetActive(false);
        }
    }

}
