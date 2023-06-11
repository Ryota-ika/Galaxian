using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerCtlr : MonoBehaviour {
    public GameObject explosion;
    public float moveSpeed = 20f;
    private Vector2 moveDirection;
    private Rigidbody2D rb;

    public GameObject Gun;
    public GameObject FirePosition;

    GameObject text;

    private float cool_down_time = 0;
    public float gun_distance = 0.2f;
    public float speed = 10f;
    GameObject objpool;
    [SerializeField] ObjctPoolController ObjPoolCtrl;
    void Start( ) {
        objpool=GameObject.Find( "objpool" );
        ObjPoolCtrl = objpool.GetComponent<ObjctPoolController>();
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
        //float moveX = Input.GetAxisRaw( "Horizontal" );
        ////float moveY = Input.GetAxisRaw( "Vertical" );
        //moveDirection = new Vector3( moveX, 0.0f, 0.0f );
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))&&transform.position.x < 4.0f)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))&& transform.position.x > -4.0f)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
    private void Move( ) {
        //rb.velocity = new Vector3( moveDirection.x * moveSpeed, 0.0f );
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

    void ChangeScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    private void OnCollisionEnter2D( Collision2D collision ) {
        if( collision.gameObject.tag == "Enemy"/*||collision.gameObject.tag=="EnemyGun"*/ ) {
            Instantiate(explosion,transform.position,Quaternion.identity);
            this.gameObject.SetActive( false );
            text = GameObject.Find("Text (Legacy)");
            Text clear_text=text.GetComponent<Text>();
            clear_text.text = "GameOver!";
            Invoke("ChangeScene", 3.0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag== "EnemyGun")
        {
            Instantiate(explosion,transform.position,Quaternion.identity);
            this.gameObject.SetActive( false );
            text = GameObject.Find("Text (Legacy)");
            Text clear_text = text.GetComponent<Text>();
            clear_text.text = "GameOver!";
            Invoke("ChangeScene", 3.0f);
        }
    }
}