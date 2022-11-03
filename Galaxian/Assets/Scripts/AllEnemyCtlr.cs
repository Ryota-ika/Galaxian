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

        //�v���C���[�̌�����ς���
        //transform.position����target.transform.position�̕����Ɍ�����ς���
        Quaternion look_rotation = Quaternion.FromToRotation( transform.position, target.transform.position );
        //transform.rotation = look_rotation;
        ////2�_�Ԃ����炩�Ɉړ������邽�߂̊֐�
        transform.rotation = Quaternion.Lerp( transform.rotation, look_rotation, 0.1f );

        //Vector3 p =new Vector3(0f,-0.05f,0f);
        //target�Ɍ������đO�i
        //���ΓI
        //transform.Translate(p);
    }

    Vector3 GetPoint( Vector3 p0, Vector3 p1, Vector3 p2, float t ) {
        var a = Vector3.Lerp( p0, p1, t ); // �ΐF�̓_1
        var b = Vector3.Lerp( p1, p2, t ); // �ΐF�̓_2
        //var c = Vector3.Lerp( p2, p3, t ); // �ΐF�̓_3

        //var d = Vector3.Lerp( a, b, t );   // �F�̓_1
        //var e = Vector3.Lerp( b, c, t );   // �F�̓_2

        return Vector3.Lerp( a, b, t );    // ���F�̓_
    }

    private void OnTriggerEnter2D( Collider2D collision ) {
        if( collision.tag == "PlayerGun" ) {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive( false );
            Destroy( this.gameObject );
            //instantiate���g��������Ə������������Ȃ�̂�pooling�ɕύX
            //Instantiate(explosion,transform.position,Quaternion.identity);
        }
    }
}
