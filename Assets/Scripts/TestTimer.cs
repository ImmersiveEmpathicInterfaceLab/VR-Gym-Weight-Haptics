using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTimer : MonoBehaviour
{
    private float timeRemaining = 30f;
    public CSV_Test csvWriter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((timeRemaining -= Time.deltaTime) <= 0)
        {
            EndTest();
        }
    }

    void EndTest()
    {

    }
}
