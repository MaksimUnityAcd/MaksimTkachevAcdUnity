using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        var rotation = Quaternion.identity;
        var position = new Vector3(Random.Range(-3, 3), Random.Range(0, 0), Random.Range(-3, 3));
    }
}
