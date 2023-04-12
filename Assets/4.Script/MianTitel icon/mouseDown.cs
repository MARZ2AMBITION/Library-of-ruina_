using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mouseDown : MonoBehaviour
{
    public void SceneLoader(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
}
