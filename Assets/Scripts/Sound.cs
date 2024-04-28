using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() == null)
        {
            audioSource.Play();
        }
    }

    private void Update()
    {

    }
}




