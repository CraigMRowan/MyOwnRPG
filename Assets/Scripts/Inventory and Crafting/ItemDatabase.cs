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
            new Item(1, "Diamond Axe", "An axe made of diamond.",
            new Dictionary<string, int>
            {
                { "Power", 15 },
                { "Defence", 7 }
            }),
            new Item(2, "Diamond Great Axe", "A great axe made of diamond.",
            new Dictionary<string, int>
            {
                { "Power", 20 },
                { "Defence", 9 }
            }),
            new Item(3, "Wooden Staff", "A staff made of wood.",
            new Dictionary<string, int>
            {
                { "Power", 10 },
                { "Defence", 9 }
            })
        };
    }
}
