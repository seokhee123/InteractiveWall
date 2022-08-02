using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorkMove : MonoBehaviour
{
    public GameObject movePos; 
    private GameObject click_obj;

    void Update()
    {
  
        this.transform.position = Vector2.MoveTowards(this.transform.position, movePos.transform.position, 3f * Time.deltaTime);
               
    }

    public void Click()
    {
        click_obj.transform.position = Vector2.MoveTowards(click_obj.transform.position, movePos.transform.position, 3f * Time.deltaTime);
    }
}
