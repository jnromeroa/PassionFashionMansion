using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] List<Item> items = new List<Item>();

    public List<Item> GetItems()
    {
        return items;
    }
}
