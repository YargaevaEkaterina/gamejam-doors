  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Chouses : MonoBehaviour
{
    public string chouse1;
    public string chouse2;
    public TextMeshProUGUI chouse1_text;
    public TextMeshProUGUI chouse2_text;
    public GameObject chouse1_dia;
    public GameObject chouse2_dia;
    public GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
        chouse1_text.text = chouse1;
        chouse2_text.text = chouse2;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Key 1");
            chouse1_dia.SetActive(true);
            canvas.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Key 2");
            chouse2_dia.SetActive(true);
            canvas.SetActive(false);
        }
    }
}
