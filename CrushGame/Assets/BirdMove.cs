using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    Vector3 mousePos;
    public float speed;
    // public float interval = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float interval = Mathf.Abs(mousePos.x - Input.mousePosition.x);
            if (interval > 10)
            {
                interval = 10;
            }
            Debug.Log(interval);
            if (mousePos.x > Input.mousePosition.x)
            {
                transform.position += Vector3.left * interval * speed * Time.deltaTime;
            }
            if (mousePos.x < Input.mousePosition.x)
            {
                transform.position += Vector3.right * interval * speed * Time.deltaTime;
            }
            mousePos = Input.mousePosition;
        }
    }
}
