using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemNum;��
    public Sprite itemlmg;

}
public class Merge : MonoBehaviour
{
    public List<Item> itemdata = new List<Item>();
    public GameObject itemPrefabs; 

    public void ItemCreate(int num)
    {
        GameObject go = Instantiate(itemPrefabs);
        go.GetComponent<MergeItem>().InitItem(itemdata[num]);
    }
}
