using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // ������ ������

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // ����� ������ ���� ������ ������
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(movement * speed * Time.deltaTime);

        // �� ������ ������ �� ������ ������ ����� ������ ����:
        float limitedZ = Mathf.Clamp(transform.position.z, -1f, 1f);
        transform.position = new Vector3(transform.position.x, transform.position.y, limitedZ);
    }
}