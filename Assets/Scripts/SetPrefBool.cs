using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetPrefBool : MonoBehaviour
{
    [SerializeField] private TMP_Text settingText;
    [SerializeField] private string settingTitle;
    private float lastTrigger = 0f;
    public bool settingOn = false;
    // Start is called before the first frame update
    void Start()
    {
     PlayerPrefs.SetInt(settingTitle, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && lastTrigger + .5f <= Time.time)
        {
            lastTrigger = Time.time;
            settingOn = !settingOn;
            if(settingOn)
                PlayerPrefs.SetInt(settingTitle, 1);
            else
                PlayerPrefs.SetInt(settingTitle, 0);


            switch (settingTitle)
            {
                case ("Vibration"):
                    if(settingOn)
                        settingText.SetText(settingTitle + ": on");
                    else
                        settingText.SetText(settingTitle + ": off");
                    break;

                case ("Weight"):
                    if (settingOn)
                        settingText.SetText(settingTitle + ": Large");
                    else
                        settingText.SetText(settingTitle + ": Small");
                    break;

                case ("DomHand"):
                    if (settingOn)
                        settingText.SetText(settingTitle + ": Left");
                    else
                        settingText.SetText(settingTitle + ": Right");
                    break;

                default:
                    break;
            }
        }

    }

}
