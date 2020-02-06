using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slap : MonoBehaviour
{
    public AudioSource audioClip;
    bool played = false;
    bool removed = false;
    public bool landed = false;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //audioClip.Play();
        AudioSource audio = this.GetComponent<AudioSource>();
        //audio.Play();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Landed
    {
        get
        {
            return landed;
        }
        set
        {
            landed  = value;
        }
    }

    void OnTriggerEnter(Collider collider) {
        
        if (collider.tag == "Floor" && !removed) {
            //Debug.Log("Slap");
            Destroy(this.gameObject);
            removed = true;
            GameObject gsm = GameObject.FindGameObjectWithTag("gm");
            gsm.GetComponent<GameManager>().setCakes(-1);
        }
        if (collider.tag == "cake" && !played && collider.gameObject.GetComponent<slap>().Landed == true) {
            AudioSource audio = this.GetComponent<AudioSource>();
            audio.Play();
            played = true;
            landed = true;
            //rb.isKinematic = true;
            //audioClip.Play();
        }
    }
}
