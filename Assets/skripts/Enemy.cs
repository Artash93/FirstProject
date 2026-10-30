using System;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    public towerShot _tower;
    public int damage=20;
    [SerializeField] Transform _tranform;
    private int speed = 3; 
    public int EnemyHealth = 100;
    public Transform _target;
    public void Init(Transform target)
    {
        _target = target;
    }

   public void OnTriggerEnter(Collider other)
    {
        if( other.CompareTag("Tower"))
       { 
           Debug.Log($"Есть контакт с {other.name}");
           _tower = other.GetComponent<towerShot>();
           
           if (_tower != null)
           {
               _tower.DamegeFromEnemy(damage);
           }
       }
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

