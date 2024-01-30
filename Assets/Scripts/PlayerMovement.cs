using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // מהירות התנועה

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // קביעת התנועה בציר האופקי והאנכי
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(movement * speed * Time.deltaTime);

        // אם ברצונך להגביל את התנועה לתנועה קדימה ואחורה בלבד:
        float limitedZ = Mathf.Clamp(transform.position.z, -1f, 1f);
        transform.position = new Vector3(transform.position.x, transform.position.y, limitedZ);
    }
}