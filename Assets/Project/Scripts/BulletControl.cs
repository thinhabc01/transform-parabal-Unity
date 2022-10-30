using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    public Vector3 forward;
    public float height = 5;
    public float scaleTime = 1;

    private float timeframe = 0, y = 0;
    private Vector3 start;
    private Vector3 mid;

    void Start()
    {
        start = transform.position;
    }

    void Update()
    {
        timeframe += Time.deltaTime/scaleTime;
        mid = Vector3.Lerp(start, forward, timeframe);

        if (timeframe < 1){
            y = (-4*Mathf.Pow(timeframe,2) + 4*timeframe)*height;
            transform.position = new Vector3(mid.x, y+mid.y, mid.z);
        }
    }
}
