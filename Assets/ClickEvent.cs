using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public Animator anim;
    //public bool isClick;
    private RaycastHit2D hit;
    public bool isEarth;
    CowClick cowclick;

    private void Awake()
    {

        anim = GetComponent<Animator>();
    }

    void Start()
    {
        cowclick = GameObject.Find("cow").GetComponent<CowClick>();
    }
    void Update()
    {
        //���콺 Ŭ����
        if (Input.GetMouseButtonDown(0))
        {
            //���콺 Ŭ���� ��ǥ�� ��������
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //�ش� ��ǥ�� �ִ� ������Ʈ ã��
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);


            if (hit.collider != null)
            {
                GameObject click_obj = hit.transform.gameObject;
                Debug.Log(click_obj);
                if (click_obj == GameObject.Find("cow"))
                {
                    cowclick.cowActive = true;
                }
            }
        }
    }


}
