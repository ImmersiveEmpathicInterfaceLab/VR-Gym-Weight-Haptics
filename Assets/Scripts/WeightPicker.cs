using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bhaptics.SDK2;


public class WeightPicker : MonoBehaviour
{
    [SerializeField] private GameObject[] smallWeight, largeWeight;
    private bool hapticsOn = false;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Weight") == 0)
        {
            for(int i = 0; i < smallWeight.Length; i++)
            {
                smallWeight[i].SetActive(true);
                largeWeight[i].SetActive(false);
            }
        }

        if (PlayerPrefs.GetInt("Weight") == 1)
        {
            for (int i = 0; i < smallWeight.Length; i++)
            {
                smallWeight[i].SetActive(false);
                largeWeight[i].SetActive(true);
            }
        }

    }


    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Vibration") == 1 && !hapticsOn)
        {
            hapticsOn = true;
            StartCoroutine(HandVibrations());
        }
    }


    IEnumerator HandVibrations()
    {
        if (PlayerPrefs.GetInt("Weight") == 0)
        {
            BhapticsLibrary.Play("lefthandlowweights");
            BhapticsLibrary.Play("righthandlowweights");
        }
        else if (PlayerPrefs.GetInt("Weight") == 1)
        {
            BhapticsLibrary.Play("lefthandheavyweights");
            BhapticsLibrary.Play("righthandheavyweights");
        }
        hapticsOn = false;

        yield return new WaitForSeconds(1f);

    }
}
