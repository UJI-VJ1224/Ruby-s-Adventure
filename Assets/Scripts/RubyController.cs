using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;

    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento Horizontal
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal * Time.deltaTime;
        
        // movimiento vertical
        float vertical = Input.GetAxis("Vertical");
        position.y = position.y + 0.1f * vertical * Time.deltaTime;

        transform.position = position;
    }
}
