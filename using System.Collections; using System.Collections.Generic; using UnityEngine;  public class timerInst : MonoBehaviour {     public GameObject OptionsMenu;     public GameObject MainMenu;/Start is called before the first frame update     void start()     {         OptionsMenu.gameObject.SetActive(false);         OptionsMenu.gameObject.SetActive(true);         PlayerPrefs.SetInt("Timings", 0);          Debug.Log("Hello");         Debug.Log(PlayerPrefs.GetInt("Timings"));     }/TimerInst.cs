using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerInst : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject MainMenu;
    

    // Start is called before the first frame update
    void start()
    {
        OptionsMenu.gameObject.SetActive(false);
        OptionsMenu.gameObject.SetActive(true);
        PlayerPrefs.SetInt("Timings", 0);

        Debug.Log("Hello");
        Debug.Log(PlayerPrefs.GetInt("Timings"));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
