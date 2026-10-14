using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] public GameObject _spawn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Instantiate(_spawn, transform.position, transform.rotation);
        }

    }
}
    
