using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_ : MonoBehaviour
{
    Light lght;
    public bool l;
    public int i;
    void Start()
    {
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            Debug.Log("Q id down!");
        }
        if(Input.GetKeyUp(KeyCode.Q)){
            Debug.Log("Q id up!");
        }
    }
}
