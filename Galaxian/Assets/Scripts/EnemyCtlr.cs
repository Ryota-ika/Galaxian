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
        //�v���C���[�̕���������
        Quaternion look_rotation=Quaternion.FromToRotation(transform.position,target.transform.position);
        transform.rotation = look_rotation;
        //look_rotation.z=0;
        //look_rotation.x=0;
        ////2�_�Ԃ����炩�Ɉړ������邽�߂̊֐�
        //transform.rotation=Quaternion.Lerp(transform.rotation,look_rotation,0.1f);
        
        Vector3 p =new Vector3(0f,-0.05f,0f);
        //target�Ɍ������đO�i
        //���ΓI
        //transform.Translate(p);
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
