using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Steuerung : MonoBehaviour
{
    public float speed;
    public int beschleunigen;
    public Text Tempanzeiger;
    public int lenkung;
    public GameObject Kamera;
    public Slider Kraftstoffanzeige;
    public float Kraftstofffloat;
    public GameObject Car;
    public GameObject GameOverPanel;

    public float Kraftstoffabziehen;

    private int bremsemodus;
    private int ausrollgeschwindigkeit;

    // Start is called before the first frame update
    void Start()
    {
        beschleunigen = 0;
        ausrollgeschwindigkeit = 1;
        Kraftstofffloat = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Kraftstoffanzeige.value = Kraftstofffloat;

        //Kamrer und Auto drehen
        if (beschleunigen > 0)
        {
            //Lenkungswickel messen
            var z = SimpleInput.GetAxis("Horizontal") * Time.deltaTime * lenkung;
            //auto drehen
            transform.Rotate(0, 0, -z);
        }
        if (beschleunigen < 0)
        {
            //Lenkungswickel messen
            var z = SimpleInput.GetAxis("Horizontal") * Time.deltaTime * lenkung;
            //auto drehen
            transform.Rotate(0, 0, -z);
        }

        //Kamera drehen
        Kamera.GetComponent<Transform>().transform.rotation = this.transform.rotation;

        //Km/h anzeigen
        int kmh = beschleunigen;
        Tempanzeiger.text = kmh + " km/h";

        //Wenn Tank leer GameOver
        if(Kraftstofffloat <= 0)
        {
            GameOverPanel.SetActive(true);
        }
    }

    //voids für Steuerung
    public void Gasdreuecken()
    {
        StopAllCoroutines();
        StartCoroutine(schneller());
    }

    public void Gasloslassen()
    {
        StopAllCoroutines();
        StartCoroutine(Bewegen());
        StartCoroutine(ausrollen());
    }

    public void bremsedruecken()
    {
        StopAllCoroutines();
        StartCoroutine(bremsen());
    }

    public void bremseloslassen()
    {
        StopAllCoroutines();
        StartCoroutine(ausrollen());
        StartCoroutine(Bewegen());
    }


    //Coroutinen für Steuerung
    IEnumerator schneller()
    {
        StartCoroutine(Bewegen());
        while(beschleunigen < 30)
        {
            yield return new WaitForSecondsRealtime(0.35f);
            beschleunigen += 1;
        }
    }

    IEnumerator Bewegen()
    {
        Car.transform.Translate(0, beschleunigen * speed, 0);
        yield return new WaitForSecondsRealtime(0.01f);
        StartCoroutine(Bewegen());
    }

    IEnumerator ausrollen()
    {
        if(beschleunigen > 0)
        {
            beschleunigen -= ausrollgeschwindigkeit;
            yield return new WaitForSecondsRealtime(1f);
            StartCoroutine(ausrollen());
        }
        else if(beschleunigen < 0)
        {
            beschleunigen += ausrollgeschwindigkeit;
            yield return new WaitForSecondsRealtime(1f);
            StartCoroutine(ausrollen());
        }
        else
        {
            StopAllCoroutines();
            beschleunigen = 0;
        }
    }

    IEnumerator bremsen()
    {
        StartCoroutine(Bewegen());
        while(beschleunigen > 0)
        {
            beschleunigen -= 1;
            yield return new WaitForSecondsRealtime(0.25f);
        }
        if(beschleunigen == 0)
        {
            while (beschleunigen > -10)
            {
                beschleunigen -= 1;
                yield return new WaitForSecondsRealtime(0.4f);
            }
        }
    }

    IEnumerator kraftstoffabziehen()
    {
        if (beschleunigen != 0)
        {
            Kraftstofffloat -= (float)beschleunigen * Kraftstoffabziehen;
        }
        else
        {
            Kraftstofffloat -= 0.000006f;
        }
        yield return new WaitForSecondsRealtime(1);
        StartCoroutine(kraftstoffabziehen());
    }
}
