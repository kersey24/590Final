using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
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

        GameObject board1Obj = GameObject.Find("backboard1"); 
        Renderer board1Render = board1Obj.GetComponent<Renderer>();
        Color board1Color = board1Render.material.color;

        GameObject board2Obj = GameObject.Find("backboard2"); 
        Renderer board2Render = board2Obj.GetComponent<Renderer>();
        Color board2Color = board2Render.material.color;

        GameObject board3Obj = GameObject.Find("backboard3"); 
        Renderer board3Render = board3Obj.GetComponent<Renderer>();
        Color board3Color = board3Render.material.color;

        if(board1Color == green && board2Color == green && board3Color == green){
            GameObject go = GameObject.Find("grate");
            Destroy(go);
        }
    }
}
