using UnityEngine;

public class target : MonoBehaviour
{
    [SerializeField] public Transform cel;
    [SerializeField] public float speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, cel.position, speed * Time.deltaTime
        );
    }
}