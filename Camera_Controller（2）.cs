using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    private Transform target;
    public float Distance = 5f;

    // 新增變量，調整平滑跟隨的速度
    public float followSpeed = 0.125f;

    void Start()
    {
        // 查找目標物體
        target = FindObjectOfType<MoveObject>().transform;
    }

    void LateUpdate()  // 場景所有物件執行完后才執行
    {
        // 計算目標位置
        Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, target.position.z - Distance);

        // 使用Lerp進行平滑跟隨
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed);

        // 將相機位置設置為平滑后的位置
        transform.position = smoothedPosition;
    }
}