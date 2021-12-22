using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        //transform
    }

    // Update is called once per frame
    void Update()
    {
        //获得水平方向的值 ，在-1或1
        float h = Input.GetAxisRaw("Horizontal");
        // 获得垂直方向的值，在-1和1
        float v = Input.GetAxisRaw("Vertical");
        
        transform.Translate(new Vector2(1, 0) * h * moveSpeed * Time.deltaTime, Space.World);
        transform.Translate(new Vector2(0, 1) * v * moveSpeed * Time.deltaTime, Space.World);
    }
}
