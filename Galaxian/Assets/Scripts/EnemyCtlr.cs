using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtlr : MonoBehaviour {
    public GameObject explosion;
    public GameObject target;
    public GameObject red_enemy;
    //int red_enemies_count = 6;
    //List<GameObject> red_enemies = new List<GameObject>();
    // Start is called before the first frame update
    void Start( ) {
        //for (int i = 0; i < red_enemies_count; i++)
        //{
        //    Instantiate( red_enemy,new Vector3(1,0,0),Quaternion.identity );
        //}
    }

    // Update is called once per frame
    void Update( ) {
        //プレイヤーの向きを変える
        //transform.positionからtarget.transform.positionの方向に向きを変える
        Quaternion look_rotation =Quaternion.FromToRotation(transform.position,target.transform.position);
        //transform.rotation = look_rotation;
        ////2点間を滑らかに移動させるための関数
        transform.rotation=Quaternion.Lerp(transform.rotation,look_rotation,0.1f);
        
        //Vector3 p =new Vector3(0f,-0.05f,0f);
        //targetに向かって前進
        //相対的
        //transform.Translate(p);
    }

    private void OnTriggerEnter2D( Collider2D collision ) {
        if( collision.tag == "PlayerGun" ) {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive( false );
            Destroy( red_enemy );
            //instantiateを使いすぎると処理がおもくなるのでpoolingに変更
            //Instantiate(explosion,transform.position,Quaternion.identity);
        }
    }
}
