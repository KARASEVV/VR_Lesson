using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigColl : MonoBehaviour
{
    void OnCollisionExit(Collision body)
    {
        print(body.gameObject.name);
    }
    void OnTriggerExit(Collider body)
    {
        print(body.gameObject.name);
    }
}
