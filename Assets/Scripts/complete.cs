using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class complete : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dialogue;
    void Start()
    {
        dialogue = GameObject.Find("info_Panel");
        dialogue.SetActive(false);
        //dialogue.GetComponent<Image>().color = new Color32(255,253,132,0);
    }
    void disAnim(){
        dialogue.SetActive(false);
        Invoke("swit",2);
    }
    void swit(){
        SceneManager.LoadScene("mainMenu");
    }
    public void finish_Game(){
        dialogue.SetActive(true);
        dialogue.transform.GetChild(0).gameObject.SetActive(false);
        dialogue.transform.GetChild(1).gameObject.SetActive(true);
        Debug.Log("Anim started");
        
        
        Invoke("disAnim",4);
    }
}
