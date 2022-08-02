using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMelting : MonoBehaviour
{
    public Animator anim;
    //public bool isClick;
    private RaycastHit2D hit;
    public bool isEarth;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        //마우스 클릭시
        if (Input.GetMouseButtonDown(0))
        {
            //마우스 클릭한 좌표값 가져오기
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //해당 좌표에 있는 오브젝트 찾기
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                if(click_obj.name == "Earth")
                {
                    
                }
            }
        }
    }

    public void isClick()
    {
        anim.SetBool("isClick", true);
        Invoke("isClickAnim", 2f);
    }
    public void isClickAnim()
    {
        anim.SetBool("isClick", false);
    }
}
