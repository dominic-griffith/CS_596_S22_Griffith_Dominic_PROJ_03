using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]

public class FlockingBehavior : MonoBehaviour
{

    public Vector3 targetPoint = new Vector3(0, 0, 0);

    public void LazyFlight()
    {
        AttractorCohesion.circleTree = false;
        AttractorCohesion.followLeader = false;
        AttractorCohesion.lazyFlight = true;
    }

    public void CircleTree()
    {
        AttractorCohesion.followLeader = false;
        AttractorCohesion.lazyFlight = false;
        AttractorCohesion.circleTree = true;
    }

    public void FollowLeader()
    {
        AttractorCohesion.lazyFlight = false;
        AttractorCohesion.circleTree = false;
        AttractorCohesion.followLeader = true;
    }

}
