using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed = 10f; // 控制旋转速度

    void Update()
    {
        // 每帧旋转物体
        transform.Rotate(Vector3.up, -speed * Time.deltaTime);
    }
}