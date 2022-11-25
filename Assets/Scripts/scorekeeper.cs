using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class scorekeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public int scroe;
    public int limit;
    public complete comp;
    void Start()
    {
        text= GameObject.Find("scorekeeper").GetComponent<Text>();
        comp = gameObject.GetComponent<complete>();
        scroe = 0;
        text.text = String.Format("0  /  {0}" , limit);
    }
    
    // Update is called once per frame
    public void dec()
    {
        scroe = Math.Max(scroe-1 , 0);
        text.text = String.Format("{0}  /  {1}", scroe, limit);
    }

    public void inc(){
        scroe++;
        if(scroe == limit){
            comp.colAll();
        }
        
        text.text = String.Format("{0}  /  {1}", scroe, limit);
    }
}
