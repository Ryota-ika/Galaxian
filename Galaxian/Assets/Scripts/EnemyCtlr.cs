using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtlr : MonoBehaviour {
    public GameObject explosion;
    public GameObject target;
    // Start is called before the first frame update
    void Start( ) {

    }

    // Update is called once per frame
    void Update( ) {
        //プレイヤーの方向を向く
        Quaternion look_rotation=Quaternion.FromToRotation(transform.position,target.transform.position);
        transform.rotation = look_rotation;
        //look_rotation.z=0;
        //look_rotation.x=0;
        ////2点間を滑らかに移動させるための関数
        //transform.rotation=Quaternion.Lerp(transform.rotation,look_rotation,0.1f);
        
        Vector3 p =new Vector3(0f,-0.05f,0f);
        //targetに向かって前進
        //相対的
        //transform.Translate(p);
    }

    private void OnTriggerEnter2D( Collider2D collision ) {
        if( collision.tag == "PlayerGun" ) {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive( false );
            Destroy( this.gameObject );
            //instantiateを使いすぎると処理がおもくなるのでpoolingに変更
            //Instantiate(explosion,transform.position,Quaternion.identity);
        }
    }
}
