using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Tutorial : MonoBehaviour
{
    public int ID;
    public GameObject[] Guinya;
    // Start is called before the first frame update
    void Start()
    {
        ID = 0;
        SetAll();
    }


    void SetAll()
    {
        
        for (int i = 0; i < Guinya.Length; i++)
        {
            Guinya[i].SetActive(false);
        }

        Guinya[ID].SetActive(true);
        
        

    }

    public void btn_Change(string dir)
    {
        if(dir == "Left")
        {
            if(ID == 0)
            {
                ID = Guinya.Length - 1;
            }
            else
            {
                ID--;
            }
        }
        else
        {
            if (ID == Guinya.Length - 1)
            {
                ID = 0;
            }
            else
            {
                ID++;
            }
        }
        SetAll();
        
    }


    
}
