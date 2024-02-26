using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwing : MonoBehaviour
{
    public float swingSpeed = 2.0f; // �������� ������������ �����
    public float maxSwingAngle = 5.0f; // ������������ ���� ������������ �����
    public float minHeight = 0.0f; // ����������� ������ ������������
    public float maxHeight = 45.0f; // ������������ ������ ������������

    private float currentSwingAngle = 0.0f;
    private float targetSwingAngle = 0.0f;

    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");

        targetSwingAngle -= mouseY * swingSpeed;
        targetSwingAngle = Mathf.Clamp(targetSwingAngle, -maxSwingAngle, maxSwingAngle);

        currentSwingAngle = Mathf.Lerp(currentSwingAngle, targetSwingAngle, Time.deltaTime * 5.0f);

        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.z = currentSwingAngle;
        eulerRotation.x = Mathf.Clamp(eulerRotation.x, minHeight, maxHeight);
        transform.eulerAngles = eulerRotation;
    }
}