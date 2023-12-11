using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_3_door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        GameObject redObj = GameObject.Find("bin2_off"); 
        Renderer redRender = redObj.GetComponent<Renderer>();
        Color red = redRender.material.color;

        GameObject greenObj = GameObject.Find("bin2_on"); 
        Renderer greenRender = greenObj.GetComponent<Renderer>();
        Color green = greenRender.material.color;

        GameObject bin2Obj = GameObject.Find("bin2"); 
        Renderer bin2Render = bin2Obj.GetComponent<Renderer>();
        Color bin2Color = bin2Render.material.color;

        GameObject bin1Obj = GameObject.Find("bin1"); 
        Renderer bin1Render = bin1Obj.GetComponent<Renderer>();
        Color bin1Color = bin1Render.material.color;

        GameObject bin0Obj = GameObject.Find("bin0"); 
        Renderer bin0Render = bin0Obj.GetComponent<Renderer>();
        Color bin0Color = bin0Render.material.color;

        GameObject bin9Obj = GameObject.Find("bin9"); 
        Renderer bin9Render = bin9Obj.GetComponent<Renderer>();
        Color bin9Color = bin9Render.material.color;

        if(bin2Color == green && bin1Color == green && bin0Color == red && bin9Color == green){
            GameObject go = GameObject.Find("room_3_door");
            Destroy(go);
        }

    }
}
