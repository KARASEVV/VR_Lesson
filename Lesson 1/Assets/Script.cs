using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    public int i = 1;
    public float f = 1.2f;
    public double d = 1.2;
    string s = "mkobfkmlb";
    [SerializeField]
    private char c ='c';

    public GameObject gm;
    Transform tr;
    public Text txt;

    void Start()
    {
        Debug.Log("void Start");
    }
    void Update()
    {
        Debug.Log("void Update");
    }
    public void ButtonClick(){
        i++;
        txt.text = ""+i;
    }
}
