using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject loadingScreen;
    public static GameManager instance;

    private void Awake()
    {
        instance = this;

        SceneManager.LoadSceneAsync((int)SceneIndexes.MAINMENU, LoadSceneMode.Additive);
    }

   
    public void LoadGame()
    {
        loadingScreen.gameObject.SetActive(true);
        SceneManager.UnloadSceneAsync((int)SceneIndexes.MAINMENU);
        SceneManager.LoadSceneAsync((int)SceneIndexes.TUTORIAL, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync((int)SceneIndexes.LEVEL_1, LoadSceneMode.Additive);
    }
}
