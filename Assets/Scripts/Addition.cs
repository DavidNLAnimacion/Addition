using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public int number;
    void Start()
    {
        
        int sum = CalculateSum(number);
        Debug.Log("La suma de los números del 1 al " + number + " es: " + sum);
    }

    int CalculateSum(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        return sum;
    }
}
