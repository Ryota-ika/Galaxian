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
        //�v���C���[�̌�����ς���
        //transform.position����target.transform.position�̕����Ɍ�����ς���
        Quaternion look_rotation =Quaternion.FromToRotation(transform.position,target.transform.position);
        //transform.rotation = look_rotation;
        ////2�_�Ԃ����炩�Ɉړ������邽�߂̊֐�
        transform.rotation=Quaternion.Lerp(transform.rotation,look_rotation,0.1f);
        
        //Vector3 p =new Vector3(0f,-0.05f,0f);
        //target�Ɍ������đO�i
        //���ΓI
        //transform.Translate(p);
    }

    private void OnTriggerEnter2D( Collider2D collision ) {
        if( collision.tag == "PlayerGun" ) {
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive( false );
            Destroy( red_enemy );
            //instantiate���g��������Ə������������Ȃ�̂�pooling�ɕύX
            //Instantiate(explosion,transform.position,Quaternion.identity);
        }
    }
}
