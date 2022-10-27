using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExamp : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("WaitAndPrint");
    }
    IEnumerator WaitAndPrint()
    {
        print("WaitAndPrint запущена");
        yield return new WaitForSeconds(5);
        print("Прошло 5 секунд");
        yield return new WaitForSeconds(5);
        print("Прошло еще 5 секунд");
    }
}
