using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuAds1 : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);

    #if UNITY_ADS


            // Show an ad 
            AdController.ShowAd();

        #endif
    }
}


