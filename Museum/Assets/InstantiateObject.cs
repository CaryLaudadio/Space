using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{
    public GameObject prefab;

    public void InstantiatePrefab()
    {
        Instantiate(prefab, transform.position, transform.rotation, null);
    }
}
