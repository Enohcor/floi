using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    private Transform target;
    public float Distance = 5f;

    // �s�W�ܶq�A�վ㥭�Ƹ��H���t��
    public float followSpeed = 0.125f;

    void Start()
    {
        // �d��ؼЪ���
        target = FindObjectOfType<MoveObject>().transform;
    }

    void LateUpdate()  // �����Ҧ�������槹�Z�~����
    {
        // �p��ؼЦ�m
        Vector3 desiredPosition = new Vector3(target.position.x, transform.position.y, target.position.z - Distance);

        // �ϥ�Lerp�i�業�Ƹ��H
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed);

        // �N�۾���m�]�m�����ƦZ����m
        transform.position = smoothedPosition;
    }
}