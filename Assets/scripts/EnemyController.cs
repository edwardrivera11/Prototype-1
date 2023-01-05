using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


     private float speed = 50;
    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.forward * Time.deltaTime * speed);
      
    }
}
