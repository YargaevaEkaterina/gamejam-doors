using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalScene : MonoBehaviour
{
    private SceneManagering _sceneManager;
    private emptyScene _emptyScene;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tree")
        {
            _emptyScene.SaveTextToPrefs("PlayerIs", "Loh");
            Debug.Log("Loh!");
            _sceneManager.GoToScene(1);
        }
        if (other.tag == "Flowers")
        {
            Debug.Log("flowers win!");
        }
    }
}
