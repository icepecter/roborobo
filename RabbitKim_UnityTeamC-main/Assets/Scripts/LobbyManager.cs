using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour
{
    public static LobbyManager instance;

    public bool _windosws = false;
    public bool _android = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(instance);
        }
    }

    public void Game_start()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
