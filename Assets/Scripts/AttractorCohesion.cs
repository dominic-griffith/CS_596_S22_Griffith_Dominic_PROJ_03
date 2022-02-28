using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractorCohesion : MonoBehaviour
{

    static public Vector3 POS = Vector3.zero;

    [Header("Set in Inspector")]
    public float radius = 10;
    public float xPhase = 0.5f;
    public float zPhase = 0.5f;
    public float speed = 0.5f;
    public float z = 0f;

    static public bool lazyFlight = false;
    static public bool circleTree = false;
    static public bool followLeader = false;

    private void FixedUpdate()
    {
        if(circleTree)
        {
            Vector3 tPos = Vector3.zero;
            Vector3 scale = transform.localScale;

            tPos.x = Mathf.Cos(xPhase * Time.time) * radius * scale.x;
            tPos.y = 10;
            tPos.z = Mathf.Sin(zPhase * Time.time) * radius * scale.z;

            transform.position = tPos;
            POS = tPos;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(lazyFlight)
        {
            transform.position = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
            POS = transform.position;
        }
    }

    private void Update()
    {
        if(followLeader)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            if(Input.GetKey("space"))
            {
                z = 1f;
            }
            else if(Input.GetKey("left shift"))
            {
                z = -1f;
            }
            else
            {
                z = 0f;
            }
            Vector3 direction = new Vector3(horizontal, z, vertical);

            transform.position += direction * speed;
            POS = transform.position;


        }
    }
}
