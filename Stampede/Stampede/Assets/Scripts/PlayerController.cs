using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float xRange = 15.0f;
    public bool gameOver = false;
    public ParticleSystem dirtParticle;


    public AudioClip jumpSound;

    private Animator playerAnimator;
    private Rigidbody playerRigidbody;
    private AudioSource playerAudioSource;

    
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
        playerAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (this.transform.position.x < -xRange)
        {
            this.transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (this.transform.position.x > xRange)
        {
            this.transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.y < 0.5f )
        {
            
            playerAnimator.SetBool("Jump_b", false);
        }
        float fHorizontal = Input.GetAxis("Horizontal");

        if (fHorizontal < 0)
        {
            transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
            dirtParticle.transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
            dirtParticle.Play();
            playerAnimator.SetFloat("Speed_f", 5);
        }
        else if (fHorizontal > 0)
        {
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
            dirtParticle.transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
            dirtParticle.Play();
            playerAnimator.SetFloat("Speed_f", 5);
        }
        else
        {
            transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
            dirtParticle.Stop();
            playerAnimator.SetFloat("Speed_f", 0);
        }
        this.transform.Translate(Vector3.right * fHorizontal * Time.deltaTime * speed, Space.World);

        if (transform.position.y < 0.5f && Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRigidbody.AddForce(Vector3.up * 500);

            dirtParticle.Stop();
            playerAnimator.SetBool("Jump_b", true);
            playerAudioSource.PlayOneShot(jumpSound, 1);
        }

    }
    public void Die()
    {

    }
}
