using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 7f;
    Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        transform.position = new Vector3(startPos.x + Mathf.PingPong(Time.time * speed, 30f), transform.position.y, transform.position.z);
    }
}
