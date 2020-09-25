using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items;

    void Awake()
    {
        BuildItemDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string title)
    {
        return items.Find(item => item.title == title);
    }

    void BuildItemDatabase()
    {
        items = new List<Item>()
        {
            new Item(1, "Diamond Axe", "A sword made of diamond.",
            new Dictionary<string, int>
            {
                { "Power", 15 },
                { "Defence", 7 }
            })
        };
    }
}
