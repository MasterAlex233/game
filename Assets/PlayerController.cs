using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform mainCameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        mainCameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main == null)
            return;

        handleMouseScroll();
        handleTransformCamera();
    }

    // 鼠标滚轮控制FOV
    private void handleMouseScroll()
    {
        if (Input.GetAxis("Mouse ScrollWheel") == 0)
            return;
        Camera.main.fieldOfView = Camera.main.fieldOfView - Input.GetAxis("Mouse ScrollWheel") * 30;
    }
    // 方向键控制相机移动
    private void handleTransformCamera()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            mainCameraTransform.Translate(Vector2.up * Time.deltaTime * 10);
            return;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            mainCameraTransform.Translate(Vector2.down * Time.deltaTime * 10);
            return;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            mainCameraTransform.Translate(Vector2.right * Time.deltaTime * 10);
            return;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            mainCameraTransform.Translate(Vector2.left * Time.deltaTime * 10);
            return;
        }
    }
}
