using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform Cube, Sphere, Cylinder;
    Vector3 OrigCubePos;
    Vector3 OrigCubeRot;
    public float CubeSpeed = 3f;
    public float CubeRotSpeed = .125f;

    Vector3 OrigCameraPos;
    Vector3 OrigCameraRot;


    // Start is called before the first frame update
    void Start()
    {
        OrigCubePos = Cube.position;
        OrigCameraPos = this.transform.position;
        OrigCubeRot = Cube.rotation.eulerAngles;
        OrigCameraRot = this.transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 DeltaCubePos;
        DeltaCubePos = ( Cube.position - OrigCubePos ) * CubeSpeed;
        this.transform.position = OrigCameraPos + DeltaCubePos;

        Vector3 DeltaCubeRot;
        DeltaCubeRot = (Cube.rotation.eulerAngles - OrigCubeRot) * CubeRotSpeed;
        Quaternion newRotation;
        newRotation = Quaternion.Euler(OrigCameraRot + DeltaCubeRot);
        this.transform.rotation = newRotation;



    }
}
