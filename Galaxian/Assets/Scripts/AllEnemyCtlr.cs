using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemyCtlr : MonoBehaviour
{
    GameObject target;

    public GameObject position1;
    public GameObject position2;
    Vector3 p0;
    Vector3 p1;
    Vector3 p2;
    float t=0;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find( "player" );

        p1 = position1.transform.position;
        p2= position2.transform.position;
        p0= this.gameObject.transform.position;
        //position1.transform.position = new Vector3(1,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position=GetPoint(p0,p1,p2,t);
        t+=0.5f*Time.deltaTime;

        //プレイヤーの向きを変える
        //transform.positionからtarget.transform.positionの方向に向きを変える
        Quaternion look_rotation = Quaternion.FromToRotation( transform.position, target.transform.position );
        //transform.rotation = look_rotation;
        ////2点間を滑らかに移動させるための関数
        transform.rotation = Quaternion.Lerp( transform.rotation, look_rotation, 0.1f );

        //Vector3 p =new Vector3(0f,-0.05f,0f);
        //targetに向かって前進
        //相対的
        //transform.Translate(p);
    }

    Vector3 GetPoint( Vector3 p0, Vector3 p1, Vector3 p2, float t ) {
        var a = Vector3.Lerp( p0, p1, t ); // 緑色の点1
        var b = Vector3.Lerp( p1, p2, t ); // 緑色の点2
        //var c = Vector3.Lerp( p2, p3, t ); // 緑色の点3

        //var d = Vector3.Lerp( a, b, t );   // 青色の点1
        //var e = Vector3.Lerp( b, c, t );   // 青色の点2

        return Vector3.Lerp( a, b, t );    // 黒色の点
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
