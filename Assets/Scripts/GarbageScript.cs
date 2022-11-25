using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
using UnityEngine.UI;
using System;
public class GarbageScript : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    public rightwrong eventController;
    public scorekeeper scoreKeeper;
    
    private bool drag;
    private float distance;
    private RaycastHit hit;
    private float dist1;
    private float yCompensation;
    public DropRecipient d1;
    public DropRecipient d2;
    public DropRecipient d3;
    private Vector3 orgpos;
    public Vector3 orgn_scale;
    public GameObject plae;
    public Vector3 org_scale;
    void Start(){
        plae=  GameObject.Find("player");
        org_scale = transform.localScale;
        orgpos = gameObject.transform.position;
        eventController = GameObject.FindWithTag("evhand").GetComponent<rightwrong>();
        scoreKeeper = GameObject.FindWithTag("evhand").GetComponent<scorekeeper>();
        yCompensation = GetComponent<MeshCollider>().bounds.size.y;
        d1 = GameObject.Find("bin1").GetComponent<DropRecipient>();
        d2 = GameObject.Find("bin2").GetComponent<DropRecipient>();
        d3 = GameObject.Find("bin3").GetComponent<DropRecipient>();
    }
    // Update is called once per frame
    void Update()
    {
        
        if (drag){
            transform.localScale = orgn_scale * (transform.position - plae.transform.position).magnitude;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            dist1 = Physics.Raycast(ray, out hit) ? hit.distance : 2147483647;
            Vector3 rayPoint = ray.GetPoint(Math.Min(distance,dist1));
            rayPoint.y += yCompensation/3;
            transform.position = rayPoint;
            
        }

    }
    public void OnPointerDown(PointerEventData eventData){
        orgn_scale = transform.localScale / ((transform.position - plae.transform.position).magnitude) ;
        Time.timeScale = 0;
        distance = 7;
        drag=true;
        
    }
    public void OnPointerUp(PointerEventData eventData){
        drag=false;
        Time.timeScale=1;
        if (d1.mouseOn){
            if(eventController.collect(gameObject.tag , 1)){
                scoreKeeper.inc();
                Destroy(gameObject);
            } else {
                scoreKeeper.dec();
                transform.position=orgpos;
                transform.localScale=org_scale;
            }
            
        } else if (d2.mouseOn) {
            if(eventController.collect(gameObject.tag , 2)){
                scoreKeeper.inc();
                Destroy(gameObject);
            } else {
                scoreKeeper.dec();
                transform.position=orgpos;
                transform.localScale=org_scale;
            }
        } else if (d3.mouseOn) {
            if(eventController.collect(gameObject.tag , 3)){
                scoreKeeper.inc();
                Destroy(gameObject);
            } else {
                scoreKeeper.dec();
                transform.position=orgpos;
                transform.localScale=org_scale;
            }
        }
    }


    
}
