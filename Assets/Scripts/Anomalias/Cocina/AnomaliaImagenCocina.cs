using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnomaliaImagenCocina : AnomaliaImagen
{
    public Material materialToActivate, materialToRemove;

    public override void Activate()
    {
        objectToActivate.GetComponent<Renderer>().material = materialToActivate;
        activated = true;
    }

    public override void Deactivate()
    {
        objectToActivate.GetComponent<Renderer>().material = materialToRemove;
        activated = false;
    }
}
