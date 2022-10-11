using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeItem : MonoBehaviour
{
    SpriteRenderer sr;
    Item item;
    bool isSelect;
    GameObject contactItem;

    public void InitItem(Item i)
    {
        item = i;
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = item.itemlmg;
    }

    private void OnMouseDown()
    {
        isSelect = true;
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    private void OnMouseUp()
    {
        isSelect = false;
        if(contactItem != null)
        {
            Destroy(contactItem);
            Destroy(gameObject);
            GameObject.Find("ItemData").GetComponent<Merge>().ItemCreate(item.itemNum + 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isSelect && item.itemNum == collision.GetComponent<MergeItem>().item.itemNum)
        {
            if(contactItem != null)
            {
                contactItem.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
                contactItem = null;
            }
            contactItem = collision.gameObject;
            contactItem.GetComponent<SpriteRenderer>().color = new Color(0.7f, 0.7f, 0.7f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(item.itemNum == collision.GetComponent<MergeItem>().item.itemNum)
        {
            contactItem.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
            contactItem = null;
        }
    }
}
