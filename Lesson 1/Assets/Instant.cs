using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant : MonoBehaviour
{
    public int i;
    public GameObject prefab;
    public Transform Spawn;
    public void CupInstant()
    {
        Instantiate(prefab, Spawn.transform.position, Quaternion.identity);
    }
}
