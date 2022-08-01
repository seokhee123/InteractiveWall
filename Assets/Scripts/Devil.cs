using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Devil : MonoBehaviour
{
    public Transform Spear;
    public GameManager Manager;
    public SpriteRenderer sprRend;
    public GameObject reason;
    SpriteRenderer rend;
    Color DevC, SprC, ReaC;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        DevC = rend.color;
        SprC = sprRend.color;
        ReaC = reason.GetComponent<SpriteRenderer>().color;
    }
    private void Update()
    {

    }

    IEnumerator Attack()
    {
        Manager.Clickable = false;
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                Spear.Translate(Vector3.up * (float)Math.Sin(1) * 0.1f);
                yield return new WaitForSeconds(0.01f);
            }
            for (int j = 0; j < 30; j++)
            {
                Spear.Translate(Vector3.up * -(float)Math.Sin(1) * 0.1f);
                yield return new WaitForSeconds(0.01f);
            }

            for (int j = 0; j < 30; j++)
            {
                Spear.Translate(Vector3.up * (float)Math.Sin(1) * 0.1f);
                yield return new WaitForSeconds(0.01f);
            }
            for (int j = 0; j < 30; j++)
            {
                Spear.Translate(Vector3.up * -(float)Math.Sin(1) * 0.1f);
                yield return new WaitForSeconds(0.01f);
            }
            yield return new WaitForSeconds(0.5f);

            while (DevC.a > 0)
            {
                DevC.a -= 0.1f;
                rend.color = DevC;
                SprC.a -= 0.1f;
                sprRend.color = SprC;
                ReaC.a += 0.1f;
                reason.GetComponent<SpriteRenderer>().color = ReaC;
                yield return new WaitForSeconds(0.1f);
            }
        }
        Manager.cnt--;
        Manager.Clickable = true;

        Destroy(gameObject);
        Destroy(Spear.gameObject);
        if (Manager.cnt == 0)
        {
            Manager.WarnStart();
        }
    }

    private void OnMouseDown()
    {
        if (Manager.Clickable)
        {
            StartCoroutine(Attack());
        }
    }
}