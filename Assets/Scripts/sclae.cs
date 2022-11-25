using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sclae : MonoBehaviour
{
    
    public Vector3 orgn_scale;
    public GameObject plae;
    void Start(){
        plae=  GameObject.Find("player");
        orgn_scale = transform.localScale / ((transform.position - plae.transform.position).magnitude) ;
    }

    void Update(){
        transform.localScale = orgn_scale * (transform.position - plae.transform.position).magnitude;
    }
}