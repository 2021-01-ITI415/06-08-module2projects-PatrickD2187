using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderManager : MonoBehaviour
{
    public void LoadSceneProspector()
    {
        SceneManager.LoadScene("__Prospector_Scene_0");
    }

    public void LoadSceneGolfSolitaire()
    {
        SceneManager.LoadScene("GolfSolitaire_Scene_1");
    }
}
