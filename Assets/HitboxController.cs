using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxController : MonoBehaviour
{

    public GameObject Target;
    public Vector3 TargetPos;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TargetPos = Target.transform.position;
        this.transform.position = TargetPos;
    }
}
