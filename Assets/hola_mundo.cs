using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hola_mundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int num1;
    public int num2;
    public void hola()
    {
        if (num1 == num2 || num2 > num1)
        {
            Debug.Log("Error. Asegúrese de que num1 sea mayor que num2");
        }
        else
        {
            while (num1 >= num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }
        /*int i = 1;
        while (i < 101)
        {
            Debug.Log(i);
            i++;
        }*/
    }
}
