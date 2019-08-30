using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    void calculator(int a, int b)
    {
        int c = a + b;
        int d = a - b;
        int e = a * b;
        int f = a / b;
        int g = a % b;
        Debug.Log(c + ", " + d + ", " + e + ", " + f +", " + g); 

    }
    void Start()
    {
        calculator(12, 5);
            
    }

}
