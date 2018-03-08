using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.UI;

public class Share : MonoBehaviour {

   

    private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";


    public void ShareToTW(string message)
    {
        
        
        Application.OpenURL(TWITTER_ADDRESS +
           "?text=" + WWW.EscapeURL(message));
    }

}
