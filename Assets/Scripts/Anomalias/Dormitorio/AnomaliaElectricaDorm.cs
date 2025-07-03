using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class AnomaliaElectricaDorm : AnomaliaElectrica
{
    public AudioSource audioSource;
    public Light luzPantalla;
    public Material materialPantallaPrendida, materialPantallaApagada;
   
    public override void Activate()
    {
        objectToActivate.GetComponent<Renderer>().material = materialPantallaPrendida;

        // Activar sonido
        if (audioSource != null && !audioSource.isPlaying)
            audioSource.Play();

        // Activar luz
        if (luzPantalla != null)
            luzPantalla.enabled = true;

        activated = true;
    }

    public override void Deactivate()
    {
        // Alternar pantallas
        objectToActivate.GetComponent<Renderer>().material = materialPantallaApagada;

        // Detener sonido
        if (audioSource != null && audioSource.isPlaying)
            audioSource.Stop();

        // Apagar luz
        if (luzPantalla != null)
            luzPantalla.enabled = false;

        activated = false;
    }
}
