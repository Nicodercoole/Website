using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hauptmenue : MonoBehaviour
{

    public Text Play;
    public Text Einstellungen;
    public Text Updates;
    public Text Verlassen;


    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Sprache") == 0)
        {
            Play.text = "Spielen";
            Einstellungen.text = "Einstellungen";
            Updates.text = "Aktualisieren";
            Verlassen.text = "Verlassen";
        }
        else
        {
            Play.text = "Play";
            Einstellungen.text = "Settings";
            Updates.text = "Updates";
            Verlassen.text = "Quit";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Updatenumber;
    public int Einstellungennumber;
    public int Playnumber;

    public void QuitButton()
    {
        Application.Quit();
    }

    public void UpdatesButton()
    {
        SceneManager.LoadScene(Updatenumber);
    }

    public void EinstellungenButton()
    {
        SceneManager.LoadScene(Einstellungennumber);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(Playnumber);
    }
}
