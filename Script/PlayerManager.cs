using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] cars;

    // Start is called before the first frame update
    void Start()
    {
        int Auto = PlayerPrefs.GetInt("AusgewaehltesAuto");
        cars[Auto].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
