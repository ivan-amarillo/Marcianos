using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoNave : MonoBehaviour
{
    [SerializeField] Transform prefabExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 6.47)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemigo")
        {
            Transform explosion = Instantiate(prefabExplosion, other.transform.position,
                Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(explosion.gameObject, 1.5f);
            Destroy(gameObject);
            
        }
        
    }
}
