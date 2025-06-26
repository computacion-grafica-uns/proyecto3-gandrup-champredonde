using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class AnomaliaElectricaDorm : AnomaliaElectrica
{
    public GameObject pantallaApagadaGO;
    public GameObject pantallaEncendidaGO;

    public AudioSource audioSource;
    public Light luzPantalla;
    public VideoPlayer videoPlayer;

    void Awake()
    {
        Deactivate(); // Asegura que arranque apagada
    }

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Prepare();
        }
    }

    public override void Activate()
    {
        Debug.Log("🔌 [AnomaliaElectricaDorm] ACTIVADA en " + gameObject.name);
        base.Activate();

        // Alternar pantallas
        if (pantallaApagadaGO != null) pantallaApagadaGO.SetActive(false);
        if (pantallaEncendidaGO != null) pantallaEncendidaGO.SetActive(true);

        // Activar sonido
        if (audioSource != null && !audioSource.isPlaying)
            audioSource.Play();

        // Activar luz
        if (luzPantalla != null)
            luzPantalla.enabled = true;

        // Reproducir video
        if (videoPlayer != null && !videoPlayer.isPlaying)
        {
            videoPlayer.frame = 0;
            videoPlayer.Play();
        }

        activated = true;
    }

    public override void Deactivate()
    {
        base.Deactivate();

        // Alternar pantallas
        if (pantallaApagadaGO != null) pantallaApagadaGO.SetActive(true);
        if (pantallaEncendidaGO != null) pantallaEncendidaGO.SetActive(false);

        // Detener sonido
        if (audioSource != null && audioSource.isPlaying)
            audioSource.Stop();

        // Apagar luz
        if (luzPantalla != null)
            luzPantalla.enabled = false;

        // Detener video
        if (videoPlayer != null && videoPlayer.isPlaying)
            videoPlayer.Stop();

        activated = false;
    }

    public override bool CheckAnomalyType(string type)
    {
        return type.Equals("Electrica");
    }
}
