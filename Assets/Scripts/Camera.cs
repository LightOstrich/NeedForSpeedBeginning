using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private InputController _prefab;
    [SerializeField]
    private Vector3 _offset;

    // Start is called before the first frame update
    void Start()
    {
        _prefab = FindObjectOfType<InputController>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _prefab.transform.position + _offset;
    }
}