using UnityEngine;

public class bullet : MonoBehaviour
{
    public Enemy _enemy;
    [SerializeField] public float speed;

    [SerializeField] public int uron = 25;

    [SerializeField] private Transform _target;

    public void Init(Transform target)
    {
        _target = target;
    }
    

    void OnTriggerEnter(Collider other) // важно
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Есть контакт с " + other.name);
            _enemy = other.GetComponent<Enemy>();
            
            if (_enemy != null)
            { 
                _enemy.GetDamage(uron);
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    { 
        transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime
        );

    }
}

