using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{
    
    private int fruits = 1;
    [SerializeField] private AudioSource soundCollectorEffect;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Fruits"))
        {
           
           
            Animator animator = collision.gameObject.GetComponent<Animator>();
            animator.Play("Collected");
            Destroy(collision.gameObject, animator.GetCurrentAnimatorStateInfo(0).length);
            soundCollectorEffect.Play();
            ScoreManager.AddScore(fruits);
            print(fruits);
        }
        
    }
    
}
