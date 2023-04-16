using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float speed = 10f;

    // Update is called once per frame
    private void Update()
    {
        if (Camera.main != null)
        {
            
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }

    }
    
    
}
