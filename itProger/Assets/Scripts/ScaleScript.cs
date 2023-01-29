using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    [SerializeField] private Transform Sphere;    
    [SerializeField] private float Speed = 1.5f;
    public float nSize = 3f;
    Vector3 newSize;
    


    // Start is called before the first frame update
    void Start()
    {
        newSize = new Vector3(transform.localScale.x * nSize, transform.localScale.y * nSize, transform.localScale.z * nSize);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.MoveTowards(transform.localScale, newSize, Time.deltaTime * Speed);
        
    }
}
