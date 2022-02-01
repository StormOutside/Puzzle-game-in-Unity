using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleController : MonoBehaviour
{
    Vector2 firstTouchPositin;
    Vector2 secondTouchPosition;
    Vector2 currentSwipe;
    public LayerMask emptyPazzle;
    [SerializeField] Transform emptyPazzzlePosition;
    [SerializeField] Transform pazlle;
    [SerializeField] Transform pointToRayRight;
    [SerializeField] Transform pointToRayLeft;
    [SerializeField] Transform pointToRayUp;
    [SerializeField] Transform pointToRayDown;
    public AudioSource audioSlide;
    public AudioClip slideClip;

 
       private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstTouchPositin = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }
       private void OnMouseUp()
        {
            if (Input.GetMouseButtonUp(0))
            {
            audioSlide.PlayOneShot(slideClip);
            secondTouchPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                currentSwipe = new Vector2(secondTouchPosition.x - firstTouchPositin.x, secondTouchPosition.y - firstTouchPositin.y);
                
                currentSwipe.Normalize();
               
            }
        if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
        {
           
            RaycastHit2D raycastHit2D = Physics2D.Raycast(pointToRayUp.position, currentSwipe, 1.0f, emptyPazzle);
            if (raycastHit2D.transform != null)
            {
                Vector2 lastEpmtyPazzlePosition = emptyPazzzlePosition.position;
                emptyPazzzlePosition.position = new Vector2(pazlle.position.x, pazlle.position.y);
                pazlle.position = new Vector2(lastEpmtyPazzlePosition.x, lastEpmtyPazzlePosition.y);
            }
        }
        if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
        {
           
            RaycastHit2D raycastHit2D = Physics2D.Raycast(pointToRayDown.position, currentSwipe, 1.0f, emptyPazzle);
            if (raycastHit2D.transform != null)
            {
                Vector2 lastEpmtyPazzlePosition = emptyPazzzlePosition.position;
                emptyPazzzlePosition.position = new Vector2(pazlle.position.x, pazlle.position.y);
                pazlle.position = new Vector2(lastEpmtyPazzlePosition.x, lastEpmtyPazzlePosition.y);
              
            }
        }
        if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
        {
           
            RaycastHit2D raycastHit2D = Physics2D.Raycast(pointToRayLeft.position, currentSwipe, 1.0f, emptyPazzle);
            if (raycastHit2D.transform != null)
            {
                Vector2 lastEpmtyPazzlePosition = emptyPazzzlePosition.position;
                emptyPazzzlePosition.position = new Vector2(pazlle.position.x, pazlle.position.y);
                pazlle.position = new Vector2(lastEpmtyPazzlePosition.x, lastEpmtyPazzlePosition.y);
            }
        }
        if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
        {
           
            RaycastHit2D raycastHit2D = Physics2D.Raycast(pointToRayRight.position, currentSwipe, 1.0f, emptyPazzle);
            if (raycastHit2D.transform != null)
            {
                Vector2 lastEpmtyPazzlePosition = emptyPazzzlePosition.position;
                emptyPazzzlePosition.position = new Vector2(pazlle.position.x, pazlle.position.y);
                pazlle.position = new Vector2(lastEpmtyPazzlePosition.x, lastEpmtyPazzlePosition.y);
            }
        }

       }
    }


   
            
            
        
     
    
   