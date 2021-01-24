using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zahlungsmittelanzeigen : MonoBehaviour
{
    public Text Coins;
    public Text Dias;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Auslesen());
    }

    IEnumerator Auslesen()
    {
        if (PlayerPrefs.GetInt("Sprache") == 0)
        {
            Dias.text = PlayerPrefs.GetInt("Dias") + "Dias";
            Coins.text = PlayerPrefs.GetInt("Coins") + "Münzen";
        }
        else
        {
            Dias.text = PlayerPrefs.GetInt("Dias") + "Dias";
            Coins.text = PlayerPrefs.GetInt("Coins") + "Coins";
        }
        yield return new WaitForSecondsRealtime(1);
        StartCoroutine(Auslesen());
    }
}
