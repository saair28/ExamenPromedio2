using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tamaños : MonoBehaviour
{
    public GameObject[] Tamaño;
    private int TamañoActual;

    public void SwitchTamaños()
    {
        if (TamañoActual == Tamaño.Length - 1)
        {
            TamañoActual = 0;
        }
        else
        {
            TamañoActual++;
        }

        TamañoActual++;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Tamaño.Length; i++)
        {
            if (i == TamañoActual)
            {
                Tamaño[i].SetActive(true);
            }
            else
            {
                Tamaño[i].SetActive(false);
            }
        }
    }
}
