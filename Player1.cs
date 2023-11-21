using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float Speed;
    public GameObject Menu;
    AudioSource Sound;
    float horizontalInput;
    public GameObject Win;
    public GameObject Bullet;
    public GameObject Sar;
    

    // Start is called before the first frame update
    void Start()
    {
        Sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0))
        {
            transform.Translate(new Vector3(horizontalInput * Speed * Time.deltaTime, 0f, 0f));
        }
    }

    void OnTriggerEnter2D(Collider2D tagsPlayer)
    {
        if (tagsPlayer.tag == "Barriers")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
        
        if(tagsPlayer.tag == "Win")
        {
            Win.SetActive(true);
        }
        if(tagsPlayer.tag == "Enemy")
        {
            Destroy(gameObject);
            Menu.SetActive(true);
        }
    }
}
