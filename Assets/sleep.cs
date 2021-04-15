using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleep : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enemySleep()
    {
        this.gameObject.GetComponent<ChaseAI>().enabled = false;
        Invoke("enemyAwake", 2.5f);
    }
    public void enemyAwake()
    {

        this.gameObject.GetComponent<ChaseAI>().enabled = true;
    }
}
