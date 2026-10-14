using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int EnemyHealth = 100;
    

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
        
        
    }
}
