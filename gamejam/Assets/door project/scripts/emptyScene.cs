using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyScene : MonoBehaviour
{
    public GameObject LohScene;
    public GameObject Opening;

    // Start is called before the first frame update
    void Start()
    {
        SaveTextToPrefs("PlayersFear", "Страх");
        if(PlayerPrefs.GetString("PlayerIs") == "Loh")
        {
            LohScene.SetActive(true);
        }
        else
        {
            Opening.SetActive(true);
        }
    }

    public void SaveTextToPrefs(string key, string Value)
    {
        PlayerPrefs.SetString(key, Value);
        PlayerPrefs.Save();
    }
}
