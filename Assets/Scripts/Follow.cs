using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField]
    private float followRange = 2f;
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        if (Vector3.Distance(target.position, transform.position) > followRange)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,target.position, step);
        }
    }
}
