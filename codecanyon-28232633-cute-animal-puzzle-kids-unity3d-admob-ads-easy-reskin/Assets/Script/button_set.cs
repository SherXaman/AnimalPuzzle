using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_set : MonoBehaviour
{

    public void _animation(){
        GetComponent<Animation>().Play("container_slot_anim");
    }
    public void _set_Level(int i){
        GameSystem.IDGame = i ;
    }
}
