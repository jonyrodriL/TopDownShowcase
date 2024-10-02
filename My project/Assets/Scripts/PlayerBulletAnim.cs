using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletAnim : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if( Input.GetMouseButtonDown(0))
        GetComponent<PlayerBulletAnim>();
       if( Input.GetMouseButton(1) )
            GetComponent<PlayerBulletAnim>();
    }
    
   
}
