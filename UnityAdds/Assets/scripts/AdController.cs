using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_ADS // Can only compile ad code on supported platforms 

using UnityEngine.Advertisements; // Advertisement class

#endif

public class AdController : MonoBehaviour
{
    string gameId = "3563990";
    bool testMode = true;

    void Start()
    {
        // Initialize the Ads service:
        Advertisement.Initialize(gameId, testMode);
       
    }

    public static void ShowAd()
    {
    #if UNITY_ADS

        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }

    #endif

    }

}
