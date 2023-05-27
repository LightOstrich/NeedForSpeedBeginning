using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private float _speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var position = transform.position;
        var step = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            position.x -= step;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x += step;
        }

        transform.position = position;
    }
}