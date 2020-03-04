using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleAspectRatio : MonoBehaviour
{
    public float _16x9CameraSize;
    public float _4x3CameraSize;

    private const float RATIO_16_9 = 16f / 9f;
    private const float RATIO_4_3 = 4f / 3f;

    private float _aspectRatio;
    private Camera _camera;

    // Use this for initialization
    void Start()
    {
        //https://answers.unity.com/questions/1556659/how-to-maintain-width-at-lower-aspect-ratios.html
        _camera = GetComponent<Camera>();
        _aspectRatio = (float)Screen.width / Screen.height;
        var t = (_aspectRatio - RATIO_4_3) / (RATIO_16_9 - RATIO_4_3);
        var size = Mathf.Lerp(_4x3CameraSize, _16x9CameraSize, t);
        _camera.orthographicSize = size;
    }
}
