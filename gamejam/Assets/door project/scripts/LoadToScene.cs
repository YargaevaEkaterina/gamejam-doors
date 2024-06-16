using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadToScene : MonoBehaviour
{

    public GameObject objToLoad;
    public void LoadObj()
    {
        Instantiate(objToLoad);
    }
}
