using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawn: MonoBehaviour
{
    
    [SerializeField] public Enemy _spawn;
    [SerializeField] private float time;
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
            SpawnEnemy();
            time = 0f;
        }
        
    }
    void SpawnEnemy()
    {
       var newEnemy= Instantiate(_spawn, Pointofspawn.position,Pointofspawn.rotation );
        newEnemy.Init(target);
    }
}