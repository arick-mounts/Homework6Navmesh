using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionManager : MonoBehaviour
{
    public GameStateManager gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            gm.LoseLive();
            other.gameObject.GetComponent<sleep>().enemySleep();
        }
        if (other.tag == "Coin")
        {
            gm.increaseScore();
            Destroy(other.gameObject);
        }
    }

}
