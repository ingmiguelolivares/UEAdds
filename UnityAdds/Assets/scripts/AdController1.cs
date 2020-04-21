using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_ADS // Can only compile ad code on supported platforms 

using UnityEngine.Advertisements; // Advertisement class

#endif

public class AdController1 : MonoBehaviour
{
    string gameId = "3563990";
    bool testMode = true;

    void Start()
    {
        // Initialize the Ads service:
        Advertisement.Initialize(gameId, testMode);
       
    }

    public static void ShowRewardAd()
    {
    #if UNITY_ADS


        if (Advertisement.IsReady())
        {
            var options = new ShowOptions{resultCallback = HandleShowResult};


            Advertisement.Show(options);
        }


#endif

    }



    private static void HandleShowResult(ShowResult result)
    {
    #if UNITY_ADS

        switch (result)
        {
            case ShowResult.Finished:

                scores.score += 5;
                scores.message = "Successfully shown, can continue game";
                break;
            case ShowResult.Skipped:
                scores.message = "Ad skipped, do nothing";
                break;
            case ShowResult.Failed:
                scores.message = "Ad failed to show, do nothing";
                break;
        }

    #endif
       

    }


}
