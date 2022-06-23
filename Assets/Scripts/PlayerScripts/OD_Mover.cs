using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class OD_Mover : MonoBehaviour
    {
        public float speed;
        public Animator _anims;
        public float Vertical;
        public float Horizontal;

        private void FixedUpdate()
        {
            Moves();
        }

        public void Moves()
        {
            Horizontal = Input.GetAxis("Horizontal");
            Vertical = Input.GetAxis("Vertical");
            if(Horizontal < -.1f || Horizontal > .1f)
            {
                transform.position += new Vector3(Horizontal * speed * Time.fixedDeltaTime,0, 0);
                _anims.SetFloat("x", Horizontal, 0, Time.deltaTime);
                if (Vertical < -.1f || Vertical > .1f)
                {
                    _anims.SetFloat("y", 0, 0, Time.deltaTime);
                }
            }
            else if (Vertical < -.1f || Vertical > .1f)
            {
                transform.position += new Vector3(0, Vertical * speed * Time.fixedDeltaTime, 0);
                _anims.SetFloat("y", Vertical, 0, Time.deltaTime);
                if (Horizontal < -.1f || Horizontal > .1f)
                {
                    _anims.SetFloat("x", 0, 0, Time.deltaTime);
                }
            }
            else
            {
                _anims.SetFloat("x", 0, 0, Time.deltaTime);
                _anims.SetFloat("y", 0, 0, Time.deltaTime);
            }
        }
    }

