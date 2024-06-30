using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FearScene : MonoBehaviour
{
    public TextMeshProUGUI m_Object;
    private SceneManagering _sceneManager;
    public GameObject doorsClosed;
    public GameObject doorsOpened;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        SetText(PlayerPrefs.GetString("PlayersFear"));
    }

    void SetText(string Value)
    {
        m_Object.text = Value;
    }

    public void StartTimer()
    {
        StartCoroutine(SetTimer());
    }

    IEnumerator SetTimer()
    {
        print("start");
        yield return new WaitForSeconds(10);
        print("end");
        doorsClosed.SetActive(false);
        doorsOpened.SetActive(true);
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "exit")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.gameObject.tag == "jump")
        {
           anim.Play("jump"); 
        }
    }
}
