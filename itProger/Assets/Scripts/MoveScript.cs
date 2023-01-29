using System.Net;
using UnityEngine;
using UnityEngine.UIElements;


public class MoveScript : MonoBehaviour
{
    [SerializeField] private Transform transforms;
    [SerializeField] private float _size = 4f;



    void Start() 
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, _size), transform.position.y, transform.position.z);
        
    }


}
