using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    float precioGramo = 1.25f;
    public float gramos;
    public string gusto;
    int gramosMax = 3000;
    int gramosMin = 250;
    float precio;
    // Start is called before the first frame update
    void Start()
    {
        if (gramos < gramosMin || gramos > gramosMax)
        {
            Debug.Log("ERROR: Cantidad incorrecta");
        }
        else if (gusto == "CHO" || gusto == "DDL")
        {
            precio = gramos * precioGramo;
            Debug.Log("Debe pagar" + precio + "$");
        }
        else if (gusto == "FRU")
        {
            precioGramo = precioGramo * 0.9f;
            precio = gramos * precioGramo;
            Debug.Log("Debe pagar" + precio + "$");
        }
        else
        {
            Debug.Log("Error: Sabor no identificado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
