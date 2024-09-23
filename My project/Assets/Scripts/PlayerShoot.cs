
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float shootSpeed = 10f;
    [SerializeField]
    float bulletLifetime = 2.0f;
    float timer = 0;
    [SerializeField]
    float shootDelay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //0.01666666666s of 60 fps
        //IF we press "the shoot button" (left mouse?) //&& Time.timeScale == 1
        //fire a progectile in a straight line in the direction of the mouse// Time.timeScale !=0
        if (Input.GetButton("Fire1") && timer > shootDelay)
        {
            timer = 0;
            Vector3 mousePos = Input.mousePosition; ;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            mousePos = mousePos - transform.position;
            mousePos.Normalize();
            //Debug.Log(mousePos);
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //Sawn in the bullet
            bullet.GetComponent<Rigidbody2D>().velocity = mousePos * shootSpeed;
            Destroy(bullet, bulletLifetime);
        }
    }
}
