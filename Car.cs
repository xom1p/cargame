using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float MoveSpeed => partsManager.CurEngine.MoveSpeed - CheckGround();
    public float angleForce;
    public float DecreSpeed;
    public float speedUPTimer;

    float currentSpeed;

    public float GroundCheckDistance;

    private float inputHorizontal;
    private float inputVertical;
    private float realMoveSpeed;

    public Rigidbody sphereRigid;

    public PartsManager partsManager;

    private void Awake()
    {
        sphereRigid.transform.SetParent(null);
        partsManager = FindObjectOfType<PartsManager>();
    }

    public void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");

        transform.position = sphereRigid.transform.position;
        sphereRigid.transform.rotation = transform.rotation;

        transform.Rotate(0, inputHorizontal * angleForce * Time.deltaTime, 0, Space.World);

        if (inputVertical != 0)
        {
            currentSpeed = Mathf.Lerp(currentSpeed, MoveSpeed, speedUPTimer * Time.deltaTime);
        }
        else
        {
            currentSpeed = 0;
        }
        

        transform.Rotate(0, inputHorizontal * angleForce * Time.deltaTime, 0, Space.World);

        if (currentSpeed > MoveSpeed)
        {
            currentSpeed = MoveSpeed;
        }
    }

    public void FixedUpdate()
    {
        sphereRigid.AddForce(transform.forward * inputVertical * currentSpeed, ForceMode.Acceleration);
    }

    float CheckGround()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down,out hit, GroundCheckDistance, (int)partsManager.CurWheel.GroundLayer))
        {
            if(hit.transform.gameObject != null)
            {
                Debug.Log("지정된 도로");
                return 0;
            }

        }
        return DecreSpeed;

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;

        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * GroundCheckDistance);
    }
}
