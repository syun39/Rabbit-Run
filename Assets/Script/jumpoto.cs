using UnityEngine;

public class JumpOto : MonoBehaviour
{
   
    public AudioClip _sound1;
    AudioSource _SE;
    // Start is called before the first frame update
    void Start()
    {
        _SE = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    //void Update()
   void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            _SE.PlayOneShot(_sound1);
        }
    }
}
