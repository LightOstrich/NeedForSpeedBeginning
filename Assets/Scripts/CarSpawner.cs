using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    

    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(_prefab, new Vector3(0, 0, 0), Quaternion.Euler(0, -90, 0));
    }

    // Update is called once per frame
    void Update()
    {
    }
}