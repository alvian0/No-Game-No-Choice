using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float MaxY, MaxX;
    public Manager manager;

    public void Start()
    {
        if (manager.IsCatch)
        {
            transform.position = new Vector2(Random.Range(-MaxX, MaxX), Random.Range(-MaxY, MaxY));
        }
    }
}
