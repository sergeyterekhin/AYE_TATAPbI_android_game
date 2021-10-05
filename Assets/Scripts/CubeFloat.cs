using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloat : MonoBehaviour
{
    public float speed,Rspeed;
    public Vector3 target;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * Rspeed);
        if (transform.position == target) if (target.y==-3f) target.y=-3.5f; else target.y=-3f;
    }
}
