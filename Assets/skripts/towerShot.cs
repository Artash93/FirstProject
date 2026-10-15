using UnityEngine;

public class towerShot : MonoBehaviour
{
    [SerializeField] private GameObject theGun;

    [SerializeField] private Transform fire; // выстрел ( тут мы респим пулю ) создал спавн для пули

    [SerializeField] private Transform target;

    [SerializeField] private int firetime = 2;

    private float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        timer += Time.deltaTime; // таймер

        if (timer >= firetime)
        {
            AgainBullet(); // создаст новую пулю
            timer = 0; // обнулит
        }
    }

    void AgainBullet()
    {
        Instantiate(theGun, fire.position, fire.rotation);
    }
}
    
