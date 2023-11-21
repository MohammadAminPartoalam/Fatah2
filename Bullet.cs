using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(transform.up * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D Bullet)
    {
        if (Bullet.tag == "Barriers")
        {
            Destroy(gameObject);
        }
        if (Bullet.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
