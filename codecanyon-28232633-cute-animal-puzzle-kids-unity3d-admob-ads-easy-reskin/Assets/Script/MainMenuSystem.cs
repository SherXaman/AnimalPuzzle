using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainMenuSystem : MonoBehaviour


{
    public GameObject[] Uinya;
    public TextMeshProUGUI text_score ;
        // Start is called before the first frame update
    void Start()
    {
        Music_Singleton.Instance.Cek_Muted();
        text_score.text = PlayerPrefs.GetInt("score").ToString();

    }

    // U

    public void ShowUInya(int i ){
        Uinya[i].active = true;
        Music_Singleton.Instance.s_play(0);
    }

    public void btn_mute(){
        Music_Singleton.Instance.btn_muted();
    }

    public void btn_exit(){
         Music_Singleton.Instance.s_play(0);
		if (Application.platform == RuntimePlatform.Android)
             {
                 Application.Quit();
             }
             else
             {
                 Application.Quit();
             }
	}

    public void btn_rateus(){
	    string	ss = Application.identifier ;	
		Music_Singleton.Instance.s_play(0);
		Application.OpenURL ("market://details?id="+ss);
	}

    string ss ;
	public void b_share(){
		ss = Application.identifier ;
		Music_Singleton.Instance.s_play(0);
	 AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
         AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
         intentObject.Call<AndroidJavaObject> ("setAction", intentClass.GetStatic<string> ("ACTION_SEND"));
         intentObject.Call<AndroidJavaObject> ("setType", "text/plain");
         intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), "SUBJECT");
         intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), "I got "+ PlayerPrefs.GetInt("score") + " Highscores" +", Lets Play https://play.google.com/store/apps/details?id="+ss);
         AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
         AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
         currentActivity.Call ("startActivity", intentObject);
	}
}
