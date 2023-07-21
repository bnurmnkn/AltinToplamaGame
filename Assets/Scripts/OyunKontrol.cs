using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OyunKontrol : MonoBehaviour
{
    public bool OyunAktif=true;
    public int altinSayisi=0;
    public TextMeshProUGUI altinSayisiText;
    public Button baslaButonu;
    void Start()
    {
        GetComponent<AudioSource>().Play(); 
    }

    
    void Update()
    {
        
    }
    public void AltinArttir(){
        altinSayisi+=1;
        altinSayisiText.text="Altin: "+altinSayisi;
    }
    public void oyunaBasla(){
        OyunAktif=true;
        baslaButonu.gameObject.SetActive(false);
    }
}
