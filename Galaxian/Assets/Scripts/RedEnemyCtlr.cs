using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyCtlr : AllEnemyCtlr
{
    GameObject[] red_enemies;
    public GameObject explosion;
    Vector3 player_pos;
    Vector3 enemy_pos;
    bool flame1=true;
    // Start is called before the first frame update
    //void Start()
    //{
    //    //p1 = position1.transform.position;
    //    //p2 = position2.transform.position;
    //    //p0 = this.gameObject.transform.position;
    //    //position1.transform.position = new Vector3(1, 1, 0);
    //}

    ////// Update is called once per frame
    //void Update()
    //{
    //    //this.gameObject.transform.position=GetPoint(p0,p1,p2,t);
    //    //t += 0.5f * Time.deltaTime;
    //}

    protected override void Attack( ) {
        if( flame1 ) {
            player_pos = target.transform.position;
            enemy_pos = this.transform.position;
            flame1 = false;
        }
        this.gameObject.transform.position += ( player_pos - enemy_pos ).normalized * Time.deltaTime * 2.2f;
        Debug.Log( target.transform.position.normalized );
    }
}
