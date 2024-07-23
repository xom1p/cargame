using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform Target;

    public float MoveSpeed;
    public float Height;
    public float Distance;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 dir = Target.transform.position - Target.forward * Distance + Vector3.up * Height;

        transform.position = Vector3.Lerp(transform.position, dir, MoveSpeed* Time.deltaTime);
        transform.LookAt(Target.position);
    }
}
