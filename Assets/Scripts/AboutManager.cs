using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Image = UnityEngine.UI.Image;

public class AboutManager : MonoBehaviour
{
    public static bool about = true;
    public Sprite aboutOn;
    public Sprite aboutOff;
    public void ChangeAbout()
    {
        if (about)
        {
            gameObject.GetComponent<Image>().sprite = aboutOff;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            about = false;
        }
        else
        {
            gameObject.GetComponent<Image>().sprite = aboutOn;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
            about = true;
        }
    }
}