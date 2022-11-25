using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
using UnityEngine.UI;
public class DropRecipient : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public bool mouseOn;
    void Start(){
        mouseOn = false;
    }

    public void OnPointerEnter(PointerEventData eventData){
        mouseOn = true;
        //Debug.Log("Enter");
    }
    public void OnPointerExit(PointerEventData eventData){
        mouseOn=false;
        //Debug.Log("Exit");
        
    }
}
