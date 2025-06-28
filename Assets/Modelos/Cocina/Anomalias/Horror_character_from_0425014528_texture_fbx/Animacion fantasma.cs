using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotarFantasma : MonoBehaviour
{
    public GameObject fantasma;
    public float amplitud = 0.5f;   // Altura máxima de flotación
    public float frecuencia = 1f;   // Velocidad del movimiento

    private Vector3 posicionInicial;

    void Start()
    {
        // Guardamos la posición original del fantasma
        posicionInicial = fantasma.transform.position;
    }

    void Update()
    {
        // Calculamos desplazamiento vertical tipo onda senoidal
        float desplazamientoY = Mathf.Sin(Time.time * frecuencia) * amplitud;

        // Actualizamos la posición del fantasma
        fantasma.transform.position = posicionInicial + new Vector3(0, desplazamientoY, 0);
    }
}
