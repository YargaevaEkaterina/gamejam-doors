using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FearScene : MonoBehaviour
{
    public TextMeshProUGUI m_Object;
    private SceneManagering _sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        SetText(PlayerPrefs.GetString("PlayersFear"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetText(string Value)
    {
        m_Object.text = Value;
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "exit")
        {
            _sceneManager.GoToNextScene();
        }
    }
}
