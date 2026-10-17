using UnityEngine;

public class Enemy : MonoBehaviour

{
   public GameObject _spawn;
    private float timerr=0f;
    [SerializeField] Transform _tranform;
    
    public int EnemyHealth = 50;


   
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
      timerr += Time.deltaTime;
      timer();
    }
    void timer()
    {
        if (timerr >= 2f)
        {
            NewSpawn();
            timerr = 0;
        }
    }
    void NewSpawn()
    {
        Instantiate(_spawn, _tranform.position, transform.rotation);
    }
}
