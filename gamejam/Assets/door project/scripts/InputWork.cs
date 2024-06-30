using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InputWork : MonoBehaviour
{
    public TMP_Text  gt;
    public GameObject error;
    public GameObject canvas;
    public GameObject dialogAfter;

    // Start is called before the first frame update
    void Start()
    {
        gt = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (char c in Input.inputString)
        {
            error.SetActive(false);
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (gt.text.Length != 0)
                {
                    gt.text = gt.text.Substring(0, gt.text.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
                if(gt.text == "" || gt.text == " " || gt.text == ".")
                {
                    error.SetActive(true);
                }
                else 
                {
                    Debug.Log("User entered their fear: " + gt.text);
                    SaveTextToPrefs("PlayersFear", gt.text);
                    canvas.SetActive(false);
                    dialogAfter.SetActive(true);
                }
            }
            else
            {
                gt.text += c;
            }
        }
    }

    public void SaveTextToPrefs(string key, string Value)
    {
        PlayerPrefs.SetString(key, Value);
        PlayerPrefs.Save();
    }
}
