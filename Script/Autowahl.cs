using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Autowahl : MonoBehaviour
{
    public GameObject AutoImage;
    public Sprite[] sprites;

    public Button[] AutoButton;

    public GameObject UpgradeManager;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("AusgewaehltesAuto", 0);
        int Autofreischalten = PlayerPrefs.GetInt("Autofreischalten");
        while(Autofreischalten != -1)
        {
            AutoButton[Autofreischalten].interactable = true;
            Autofreischalten -= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Auto01Button()
    {
        AutoImage.GetComponent<Image>().sprite = sprites[0];
        PlayerPrefs.SetInt("AusgewaehltesAuto", 1);
        UpgradeManager.SetActive(false);
        UpgradeManager.SetActive(true);
        AutoImage.SetActive(true);
    }
    public void Auto02Button()
    {
        AutoImage.GetComponent<Image>().sprite = sprites[1];
        PlayerPrefs.SetInt("AusgewaehltesAuto", 2);
        UpgradeManager.SetActive(false);
        UpgradeManager.SetActive(true);
        AutoImage.SetActive(true);
    }
    public void Auto03Button()
    {
        AutoImage.GetComponent<Image>().sprite = sprites[2];
        PlayerPrefs.SetInt("AusgewaehltesAuto", 3);
        UpgradeManager.SetActive(false);
        UpgradeManager.SetActive(true);
        AutoImage.SetActive(true);
    }
    public void Auto04Button()
    {
        AutoImage.GetComponent<Image>().sprite = sprites[3];
        PlayerPrefs.SetInt("AusgewaehltesAuto", 4);
        UpgradeManager.SetActive(false);
        UpgradeManager.SetActive(true);
        AutoImage.SetActive(true);
    }
    public void Auto05Button()
    {
        AutoImage.GetComponent<Image>().sprite = sprites[4];
        PlayerPrefs.SetInt("AusgewaehltesAuto", 5);
        UpgradeManager.SetActive(false);
        UpgradeManager.SetActive(true);
        AutoImage.SetActive(true);
    }
    public void Auto06Button()
    {
        AutoImage.GetComponent<Image>().sprite = sprites[5];
        PlayerPrefs.SetInt("AusgewaehltesAuto", 6);
        UpgradeManager.SetActive(false);
        UpgradeManager.SetActive(true);
        AutoImage.SetActive(true);
    }
    public void Auto07Button()
    {
        AutoImage.GetComponent<Image>().sprite = sprites[6];
        PlayerPrefs.SetInt("AusgewaehltesAuto", 7);
        UpgradeManager.SetActive(false);
        UpgradeManager.SetActive(true);
        AutoImage.SetActive(true);
    }
    public void Auto08Button()
    {
        AutoImage.GetComponent<Image>().sprite = sprites[7];
        PlayerPrefs.SetInt("AusgewaehltesAuto", 8);
        UpgradeManager.SetActive(false);
        UpgradeManager.SetActive(true);
        AutoImage.SetActive(true);
    }
}
