using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetPrefInt : MonoBehaviour
{
    [SerializeField] private TMP_Text settingText;
    [SerializeField] private string settingTitle;
    private float lastTrigger = 0f;

    // Start is called before the first frame update
    void Start()
    {
     PlayerPrefs.SetInt(settingTitle, PlayerPrefs.GetInt(settingTitle));
     settingText.SetText(settingTitle + ": " + PlayerPrefs.GetInt(settingTitle));

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && lastTrigger + .5f <= Time.time)
        {
            lastTrigger = Time.time;
            if (other.transform.position.y > this.transform.position.y)
            {
                PlayerPrefs.SetInt(settingTitle, PlayerPrefs.GetInt(settingTitle) + 1);
                settingText.SetText(settingTitle + ": " + PlayerPrefs.GetInt(settingTitle));
            }
            else
            {
                PlayerPrefs.SetInt(settingTitle, PlayerPrefs.GetInt(settingTitle) - 1);
                settingText.SetText(settingTitle + ": " + PlayerPrefs.GetInt(settingTitle));
            }
        }

    }

}
