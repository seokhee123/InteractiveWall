using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    private GameObject click_obj;
    public Animator anim;
    public GameObject earth;
    public GameObject[] pork;
    public GameObject boomObj;
    void Awake()
    {
        anim = GetComponent<Animator>();
        
    }
    private void Start()
    {
        boomObj. (false);
    }
    void Update()
    {
        //RaycastHit2D hit;
        //마우스 클릭시

        if (Input.GetMouseButtonDown(0))
        {

            //마우스 클릭한 좌표값 가져오기

            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //해당 좌표에 있는 오브젝트 찾기
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
             {
                click_obj = hit.transform.gameObject;
            }
        }

        if (GameObject.Find("Earth") == click_obj) // 지구 클릭
        {
            EarthEvent();
        }
        if (GameObject.Find("Pork") == click_obj) // 지구 클릭
        {
            PorkEvent();
        }

        if (boomObj == click_obj)
        {
            BoomEvent();
        }
        


        //click obj 초기화
        click_obj = null;
    }

    void EarthEvent() //EarthMelting 참조
    {
        earth.GetComponent<EarthMelting>().isClick();
    }

    void PorkEvent()
    {
        
    }

    void BoomEvent()
    {
        StartCoroutine("Boom");
    }

    IEnumerator Boom()
    {
        boomObj.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        boomObj.gameObject.SetActive(false);
    }
}
