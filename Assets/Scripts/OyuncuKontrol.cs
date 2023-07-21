using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public AudioClip altin,yanma;
    
    public OyunKontrol oyunk;
    private float hiz=10;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(oyunk.OyunAktif)
        {
            float x=Input.GetAxis("Horizontal");
            float y=Input.GetAxis("Vertical");

            x*=Time.deltaTime*hiz;
            y*=Time.deltaTime*hiz;

            transform.Translate(x,0f,y);
        }
        

    }
    void OnCollisionEnter(Collision birsey) {
        if(birsey.gameObject.tag.Equals("altin"))
        {
            GetComponent<AudioSource>().PlayOneShot(altin,1f);
            oyunk.AltinArttir();
            Destroy(birsey.gameObject);
        }
        else if(birsey.gameObject.tag.Equals("dusman"))
        {
            GetComponent<AudioSource>().PlayOneShot(yanma,1f);
            oyunk.OyunAktif=false;
            
        }
        
    }
}
