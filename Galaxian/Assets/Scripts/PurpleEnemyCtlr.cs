using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleEnemyCtlr : AllEnemyCtlr
{
    Vector3 p0;
    Vector3 p1;
    Vector3 p2;
    float t = 0;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        p1 = position1.transform.position;
        p2 = position2.transform.position;
        p0 = this.gameObject.transform.position;
        position1.transform.position = new Vector3(1,1,0);

    }

    // Update is called once per frame
    void Update()
    {
        //this.gameObject.transform.position = GetPoint(p0, p1, p2, t);
        t+=0.5f*Time.deltaTime;

    }

    Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
    {
        //“_1
        var a = Vector3.Lerp(p0, p1, t);
        //“_2
        var b = Vector3.Lerp(p1, p2, t);
        //var c = Vector3.Lerp( p2, p3, t );

        //var d = Vector3.Lerp( a, b, t );
        //var e = Vector3.Lerp( b, c, t );

        return Vector3.Lerp(a, b, t);
    }
}
