
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCtlr : MonoBehaviour {
    public float moveSpeed = 20f;
    private Vector2 moveDirection;
    private Rigidbody2D rb;

    public GameObject Gun;
    public GameObject FirePosition;

    private float cool_down_time = 0;
    public float gun_distance = 0.2f;

    [SerializeField] ObjctPoolController ObjPoolCtrl;
    void Start( ) {
        rb = GetComponent<Rigidbody2D>( );
        GetComponent<Rigidbody2D>( );
        //moveDirection = new Vector3( 0.0f, 0.0f,0.0f);
    }
    void Update( ) {
        ProcessInputs( );
        if( Input.GetKeyDown( KeyCode.Space ) ) {
            Fire( );
        }
        //Time.deltaTime==60ïbä‘Ç≈1ÉtÉåÅ[ÉÄï‘ÇµÇƒÇ≠ÇÍÇÈ
        cool_down_time -= Time.deltaTime;
    }
    private void FixedUpdate( ) {
        Move( );
    }
    void ProcessInputs( ) {
        float moveX = Input.GetAxisRaw( "Horizontal" );
        float moveY = Input.GetAxisRaw( "Vertical" );
        moveDirection = new Vector3( moveX, 0.0f, 0.0f );
    }
    private void Move( ) {
        rb.velocity = new Vector3( moveDirection.x * moveSpeed, 0.0f );
    }

    private void Fire( ) {
        if( cool_down_time <= 0 ) {
            //instantiateÇÃë„ÇÌÇËÇÃä÷êî
            GameObject obj = ObjPoolCtrl.GetPooledObjct( );
            if( obj == null ) {
                return;
            }
            //èeÇÃèäíËà íuéÊìæ
            obj.transform.position = FirePosition.transform.position;
            obj.transform.rotation = FirePosition.transform.rotation;
            obj.SetActive( true );
            //Instantiate(Gun,FirePosition.transform.position,FirePosition.transform.rotation);
            cool_down_time = gun_distance;
        }
    }
}