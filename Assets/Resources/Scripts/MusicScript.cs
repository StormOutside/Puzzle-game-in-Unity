using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicScript : MonoBehaviour
{
    public AudioSource audioSource;
    string activeScene;
   
   
   
   


    private void Start()
    {
        
    }
    void Awake()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    
      
   


    // Update is called once per frame
    void Update()
    {
       
     activeScene = SceneManager.GetActiveScene().name;
       if(activeScene != "Main Menu" && activeScene != "Selection of The Number Pazzle 3x3")
        {
            audioSource.Pause();

        }
       else
        {
            audioSource.UnPause();
        }
        

    }

     
}
