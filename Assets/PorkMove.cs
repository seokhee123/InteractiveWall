using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorkMove : MonoBehaviour
{
    public GameObject movePos;
    bool isClick = false;
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

                isClick = true;
            }
        }
        if(isClick == true)
            transform.position = Vector2.MoveTowards(transform.position, movePos.transform.position, 3f * Time.deltaTime);
    }
}
