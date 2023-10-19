using System;
using System.Collections.Generic;
using UnityEngine;
public class InstantiationExample : MonoBehaviour
{
    public GameObject cube;
    private List<Vector3> checkPosition;
    private Vector3 pos;
    void Start()
    {
        checkPosition = new List<Vector3> { };
        pos = new Vector3();

        for (int i = 0; i < 10; i++)
            checkPosition.Add(position());

        for (int i = 0; i < 10; i++)
        {
            pos = position();
            if (checkPosition.Contains(pos))
            {
                checkPosition.Remove(pos);
                pos = new Vector3(UnityEngine.Random.Range(1, 8), 2, UnityEngine.Random.Range(1, 8));
                checkPosition.Add(pos);
            }
        }


        for (int i = 0; i < 10; i++)
        {
            Instantiate(cube, checkPosition[i], Quaternion.identity);
        }
        
        
    }

    Vector3 position()
    {
        float x = UnityEngine.Random.Range(1, 8);
        float y = 2;
        float z = UnityEngine.Random.Range(1, 8);

    return new Vector3(x, y, z);
    }
}

