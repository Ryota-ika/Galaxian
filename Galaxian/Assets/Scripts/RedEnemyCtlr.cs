using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyCtlr : AllEnemyCtlr {
    public GameObject explosion;
    GameObject target;
    // Start is called before the first frame update
    //void Start( ) {
    //    target=GameObject.Find("player");
    //}

    //// Update is called once per frame
    //void Update( ) {
    //    //継承したのでここでは使わない

    //    //プレイヤーの向きを変える
    //    //transform.positionからtarget.transform.positionの方向に向きを変える
    //    Quaternion look_rotation =Quaternion.FromToRotation(transform.position,target.transform.position);
    //    //transform.rotation = look_rotation;
    //    ////2点間を滑らかに移動させるための関数
    //    transform.rotation=Quaternion.Lerp(transform.rotation,look_rotation,0.1f);
        
    //    //Vector3 p =new Vector3(0f,-0.05f,0f);
    //    //targetに向かって前進
    //    //相対的
    //    //transform.Translate(p);
    //}

    //private void OnTriggerEnter2D( Collider2D collision ) {
    //    if( collision.tag == "PlayerGun" ) {
    //        //Destroy(collision.gameObject);
    //        collision.gameObject.SetActive( false );
    //        Destroy( this.gameObject );
    //        //instantiateを使いすぎると処理がおもくなるのでpoolingに変更
    //        //Instantiate(explosion,transform.position,Quaternion.identity);
    //    }
    //}
}
