using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Autoupgrades : MonoBehaviour
{
    public Slider[] Upgradeslider;

    public Text[] Uebersetzen;

    public GameObject UpgradePanel;

    private int Auto;
    // Start is called before the first frame update
    void Start()
    {
        Sprache();
    }

    void Sprache()
    {
        Auto = PlayerPrefs.GetInt("AusgewaehltesAuto");

        if (PlayerPrefs.GetInt(Auto + "Geschwindigkeit") == 0)
        {
            PlayerPrefs.SetInt(Auto + "Geschwindigkeit", 1);
        }
        if (PlayerPrefs.GetInt(Auto + "Bremse") == 0)
        {
            PlayerPrefs.SetInt(Auto + "Bremse", 1);
        }
        if (PlayerPrefs.GetInt(Auto + "Tank") == 0)
        {
            PlayerPrefs.SetInt(Auto + "Tank", 1);
        }
        if (PlayerPrefs.GetInt(Auto + "Gesundheitspunkte") == 0)
        {
            PlayerPrefs.SetInt(Auto + "Gesundheitspunkte", 1);
        }

        UpgradePanel.SetActive(true);

        if (PlayerPrefs.GetInt("Sprache") == 0)
        {
            Uebersetzen[0].text = 70 * PlayerPrefs.GetInt(Auto + "Geschwindigkeit") + " Münzen";
            Uebersetzen[1].text = "Geschwindigkeit";
            Uebersetzen[2].text = 40 * PlayerPrefs.GetInt(Auto + "Bremse") + " Münzen";
            Uebersetzen[3].text = "Bremse";
            Uebersetzen[4].text = 10 * PlayerPrefs.GetInt(Auto + "Tank") + " Dias";
            Uebersetzen[5].text = "Tank";
            Uebersetzen[6].text = 15 * PlayerPrefs.GetInt(Auto + "Gesundheitspunkte") + " Dias";
            Uebersetzen[7].text = "Gesundheitspunkte";
        }
        else
        {
            Uebersetzen[0].text = 70 * PlayerPrefs.GetInt(Auto + "Geschwindigkeit") + " Coins";
            Uebersetzen[1].text = "Speed";
            Uebersetzen[2].text = 40 * PlayerPrefs.GetInt(Auto + "Bremse") + " Coins";
            Uebersetzen[3].text = "Break";
            Uebersetzen[4].text = 10 * PlayerPrefs.GetInt(Auto + "Tank") + " Dias";
            Uebersetzen[5].text = "Tank";
            Uebersetzen[6].text = 15 * PlayerPrefs.GetInt(Auto + "Gesundheitspunkte") + " Dias";
            Uebersetzen[7].text = "Healthpoints";
        }

        Upgradeslider[0].value = PlayerPrefs.GetInt(Auto + "Geschwindigkeit");
        Upgradeslider[1].value = PlayerPrefs.GetInt(Auto + "Bremse");
        Upgradeslider[2].value = PlayerPrefs.GetInt(Auto + "Tank");
        Upgradeslider[3].value = PlayerPrefs.GetInt(Auto + "Gesundheitspunkte");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Geschwindigkeitbutton()
    {
        if(70 * PlayerPrefs.GetInt(Auto + "Geschwindigkeit") >= PlayerPrefs.GetInt("Coins"))
        {
            PlayerPrefs.SetInt(PlayerPrefs.GetInt("AusgewaehltesAuto") + "Geschwindigkeit", +1);
            Sprache();
        }
    }
    public void Bremsebutton()
    {
        if (40 * PlayerPrefs.GetInt(Auto + "Geschwindigkeit") >= PlayerPrefs.GetInt("Coins"))
        {
            PlayerPrefs.SetInt(PlayerPrefs.GetInt("AusgewaehltesAuto") + "Bremse", +1);
            Sprache();
        }
    }
    public void Tankbutton()
    {
        if (10 * PlayerPrefs.GetInt(Auto + "Geschwindigkeit") >= PlayerPrefs.GetInt("Dias"))
        {
            PlayerPrefs.SetInt(PlayerPrefs.GetInt("AusgewaehltesAuto") + "Tank", +1);
            Sprache();
        }
    }
    public void Gesundheitspunktebutton()
    {
        if (15 * PlayerPrefs.GetInt(Auto + "Geschwindigkeit") >= PlayerPrefs.GetInt("Dias"))
        {
            PlayerPrefs.SetInt(PlayerPrefs.GetInt("AusgewaehltesAuto") + "Gesundheitspunkte", +1);
            Sprache();
        }
    }
}