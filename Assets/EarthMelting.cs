using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMelting : MonoBehaviour
{
    public Animator anim;
    //public bool isClick;
    private void Awake()
    {
        anim = GetComponent<Animator>();
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
                anim.SetBool("isClick", true);
                Invoke("isClickAnim", 2f);
            }

        }
    }

    void isClickAnim()
    {
        anim.SetBool("isClick", false);
    }
}
