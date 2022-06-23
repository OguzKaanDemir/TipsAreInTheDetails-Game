using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public Animator _anims;
    public float Horizontal;

    private void FixedUpdate()
    {
        Moves();
    }

    public void Moves()
    {
        Horizontal = Input.GetAxis("Horizontal");
        if (Horizontal < -.1f || Horizontal > .1f)
        {
            transform.position += new Vector3(Horizontal * speed * Time.fixedDeltaTime, 0, 0);
            _anims.SetFloat("x", Horizontal, 0, Time.deltaTime);
            
        }
        else
        {
            _anims.SetFloat("x", 0, 0, Time.deltaTime);
        }
        
    }

    public void ExitBtn()
    {
        Application.Quit();
    }

}
