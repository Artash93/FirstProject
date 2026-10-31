using UnityEngine;

public class towerShot : MonoBehaviour
{
    [SerializeField] public int Health= 100; 
    
    [SerializeField] private bullet theGun;

    [SerializeField] private Transform fire; // выстрел ( тут мы респим пулю ) создал спавн для пули

    [SerializeField] private Transform target;
    

   public float timer;
    
    
  public  void DamegeFromEnemy(int EnemyUron) 
    {
            Health -= EnemyUron;
            Debug.Log("Осталось здоровья башни: " + Health);
            if (Health <= 0)
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
       

        timer += Time.deltaTime; // таймер

        if (timer >= 2f)
        {
           
            AgainBullet(); // создаст новую пулю
            timer = 0f; 
        }
    }

    void AgainBullet()
    {
      var NewBullet=  Instantiate(theGun, fire.position, fire.rotation);
       NewBullet.Init(target);
    }
}
    
