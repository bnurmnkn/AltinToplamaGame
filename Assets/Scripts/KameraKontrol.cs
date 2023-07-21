using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    float hassasiyet=5f;
    float yumusaklik=2f;
    Vector2 gecisPoz;
    Vector2 camPoz;
    GameObject oyuncu;
    public OyunKontrol oyunk;
    void Start()
    {
        oyuncu=transform.parent.gameObject;
        camPoz.y=12f;
    }

    
    void Update()
    {
        if(oyunk.OyunAktif){
            Vector2 farePoz=new Vector2 (Input.GetAxis("Mouse X"),Input.GetAxis("Mouse Y"));
            farePoz=Vector2.Scale(farePoz,new Vector2(hassasiyet*yumusaklik,hassasiyet*yumusaklik));
            gecisPoz.x=Mathf.Lerp(gecisPoz.x,farePoz.x,1f/yumusaklik);
            gecisPoz.y=Mathf.Lerp(gecisPoz.y,farePoz.y,1f/yumusaklik);
            camPoz+=gecisPoz;

            transform.localRotation=Quaternion.AngleAxis(camPoz.y,Vector3.right);
            oyuncu.transform.localRotation= Quaternion.AngleAxis(camPoz.x,oyuncu.transform.up);
        }
    }
}
