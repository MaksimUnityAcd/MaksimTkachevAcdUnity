using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotetionScript : MonoBehaviour
{
    [SerializeField] private Transform transforms;
    [SerializeField] private float Speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transforms.Rotate(new Vector3(0, 0, -1) * Speed * Time.deltaTime);
    }
}
