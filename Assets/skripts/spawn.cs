using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] public GameObject _spawn;

    [SerializeField] private float time;
    private float speed = 3;
    [SerializeField] public Transform Pointofspawn;
    [SerializeField] public Transform target;
    
 

    void Start()
    {
       
    }
   
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 2f)
        {
            
            Spawn();
            time = 0f;
            
        }
        
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
     
    }

    void Spawn()
    {
        Instantiate(_spawn, Pointofspawn.position,Pointofspawn.rotation );
    }
}