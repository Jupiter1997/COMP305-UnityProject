﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectitems : MonoBehaviour {

    private static Collectitems _globalInstance;

    public static Collectitems GlobalInstance
    {
        get
        {
            if (_globalInstance == null)
            {
                Debug.Log("No instance found");
            }
            return _globalInstance;
        }
    }

    public Dictionary<Sprite, int> itemCount;

    void Start()
    {
        itemCount = new Dictionary<Sprite, int>();
    }

    public void CollectedItem(GameObject obj)
    {
        Sprite s = obj.GetComponent<SpriteRenderer>().sprite;

        if (!itemCount.ContainsKey(s))
        {
            itemCount.Add(s, 0);
        }

        itemCount[s] += 1;
    }

    private void Awake()
    {
        if (_globalInstance != null && _globalInstance != this)
        {
            Debug.Log("Multiple instances found");
            Destroy(this.gameObject);
        }
        else
        {
            _globalInstance = this;
        }
    }
}
