using UnityEngine;

public class Enemy : MonoBehaviour

{
    
    [SerializeField] Transform _tranform;
    private int speed = 3; 
    public int EnemyHealth = 100;
    public Transform _target;
    public void Init(Transform target)
    {
        _target = target;
    }


   
    public void TakeDamage(int uron)
    {
        EnemyHealth -= uron;
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
    }
}

