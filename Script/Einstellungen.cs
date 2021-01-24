using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Einstellungen : MonoBehaviour
{
    public GameObject Dropdownmenue;

    public Text Save;
    public Text Sprache;

    // Start is called before the first frame update
    void Start()
    {
        Dropdownmenue.GetComponent<Dropdown>().value = PlayerPrefs.GetInt("Sprache");

        if(PlayerPrefs.GetInt("Sprache") == 0)
        {
            Save.text = "Speichern";
            Sprache.text = "Sprache:";
        }
        else
        {
            Save.text = "Save";
            Sprache.text = "Language:";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveButton()
    {
        var Dropdownvalue = Dropdownmenue.GetComponent<Dropdown>();
        PlayerPrefs.SetInt("Sprache", Dropdownvalue.value);
        SceneManager.LoadScene(0);
    }
}
