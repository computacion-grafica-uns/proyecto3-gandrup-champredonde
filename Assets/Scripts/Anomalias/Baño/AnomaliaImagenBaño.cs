using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnomaliaImagenBaño : Anomalia
{
    public Material materialToActivate, materialToRemove;
    public override bool CheckAnomalyType(string type)
    {
        return type.Equals("Imagen");
    }

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
