using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtAttractorAlignment : MonoBehaviour
{

    private void Update()
    {
        transform.LookAt(AttractorCohesion.POS);
    }

}
