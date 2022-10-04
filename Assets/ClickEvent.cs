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
        //���콺 Ŭ����

        if (Input.GetMouseButtonDown(0))
        {

            //���콺 Ŭ���� ��ǥ�� ��������

            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //�ش� ��ǥ�� �ִ� ������Ʈ ã��
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
             {
                click_obj = hit.transform.gameObject;
            }
        }

        if (GameObject.Find("Earth") == click_obj) // ���� Ŭ��
        {
            EarthEvent();
        }
        if (GameObject.Find("Pork") == click_obj) // ���� Ŭ��
        {
            PorkEvent();
        }

        if (boomObj == click_obj)
        {
            BoomEvent();
        }
        


        //click obj �ʱ�ȭ
        click_obj = null;
    }

    void EarthEvent() //EarthMelting ����
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
