using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCtlr : MonoBehaviour {
    private Rigidbody2D rb;
    public float gun_speed = 8f;
    // Start is called before the first frame update
    void Start( ) {
    }
    //Gameobjectがactive化されたときに自動的に処理を行ってくれる関数
    private void OnEnable( ) {
        rb = GetComponent<Rigidbody2D>( );
        rb.velocity = new Vector3( 0, gun_speed, 0 );

    }

    // Update is called once per frame
    void Update( ) {

    }
}
