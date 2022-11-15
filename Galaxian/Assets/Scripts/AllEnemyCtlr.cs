using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AllEnemyCtlr : MonoBehaviour {
    public GameObject target;

    public GameObject position1;
    public GameObject position2;
    Vector3 p0;
    Vector3 p1;
    Vector3 p2;
    float t = 0;
    public bool move_enemy = false;
    // Start is called before the first frame update
    void Start( ) {
        target = GameObject.Find( "player" );

        p1 = position1.transform.position;
        p2 = position2.transform.position;
        p0 = this.gameObject.transform.position;
        //position1.transform.position = new Vector3(1,1,0);
    }

    // Update is called once per frame
    void Update( ) {
        //if( target.transform.position == this.gameObject.transform.position ) {

        //    target.SetActive( false );
        //}
        if( this.transform.position.y < -5 ) {
            
            this.gameObject.transform.position = new Vector3( p0.x, 8, p0.z );
            move_enemy = false;
            //pos.y -= 1;
            //if( this.gameObject.transform.position == p0 ) {
            //    this.gameObject.transform.position = p0;
            //    move_enemy = false;

            //};

        }
        //落下する処理
        if( this.transform.position.y >= p0.y&&move_enemy==false ) {
            Vector3 pos = this.gameObject.transform.position;
            pos.y -= 1*Time.deltaTime;
            this.gameObject.transform.position = pos;
        }
        if( move_enemy ) {
            if( t >= 1 ) {
                Attack( );
            }
            if( t < 1 ) {
                this.gameObject.transform.position = GetPoint( p0, p1, p2, t );
                t += 0.5f * Time.deltaTime;

            }

        }
        //this.gameObject.transform.position=GetPoint(p0,p1,p2,t);
        //t+=0.5f*Time.deltaTime;

        //プレイヤーの向きを変える
        //transform.positionからtarget.transform.positionの方向に向きを変える
        //Quaternion look_rotation = Quaternion.FromToRotation(transform.position, target.transform.position);
        //transform.rotation = look_rotation;
        ////2点間を滑らかに移動させるための関数
        //transform.rotation = Quaternion.Lerp(transform.rotation, look_rotation, 0.1f);

        //Vector3 p =new Vector3(0f,-0.05f,0f);
        //targetに向かって前進
        //相対的
        //transform.Translate(p);
    }

    protected virtual void Attack( ) {

    }

    protected virtual Vector3 GetPoint( Vector3 p0, Vector3 p1, Vector3 p2, float t ) {
        //点1
        var a = Vector3.Lerp( p0, p1, t );
        //点2
        var b = Vector3.Lerp( p1, p2, t );
        //var c = Vector3.Lerp( p2, p3, t );

        //var d = Vector3.Lerp( a, b, t );
        //var e = Vector3.Lerp( b, c, t );

        return Vector3.Lerp( a, b, t );
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
