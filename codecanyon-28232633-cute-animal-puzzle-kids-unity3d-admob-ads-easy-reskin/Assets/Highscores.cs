using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Highscores : MonoBehaviour
{

    public enum Data_Enum{
        Game1,Game2,Game3 
    }

    public Data_Enum Pilihan;
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUGUI teks = GetComponent<TextMeshProUGUI>();
        if(Pilihan == Data_Enum.Game1)
        {
            teks.text = "Highscores:\n" + PlayerPrefs.GetInt("scoreGame");
        }
        else if (Pilihan == Data_Enum.Game2)
        {
            teks.text = "Highscores:\n" + PlayerPrefs.GetInt("scoreGame1");
        }
        else if (Pilihan == Data_Enum.Game3)
        {
            teks.text = "Highscores:\n" + PlayerPrefs.GetInt("scoreGame2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
