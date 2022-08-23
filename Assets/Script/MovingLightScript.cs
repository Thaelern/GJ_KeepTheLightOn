using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLightScript : MonoBehaviour
{
    [SerializeField] float distanceToCover;
    [SerializeField] float speed;

    private Vector3 startingPostion;

    private void Start()
    {
        startingPostion = transform.position;
    }

    private void Update()
    {
        Vector3 v = startingPostion;
        v.z += distanceToCover *Mathf.Sin(Time.time * speed);
        transform.position = v;
    }

}
