<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class ControllVedio : MonoBehaviour {
    public MediaPlayer  _media;
 
    public Text textControll;
    public GameObject UI_Canvas;
    public GameObject UI_CanvasShoose;
    public GameObject Particle;

    public Slider slider;
    public float sceond;
    public Transform _Camera;
	// Update is called once per frame
	public void Play_Pause () {
        if (_media.Control.IsPlaying () ) {
            _media.Pause ();
            textControll.text = "Play";

        } else {
            _media.Play ();
            textControll.text = "Pause";
        }

    }
    public void ShooseVideo(){
        UI_Canvas.SetActive (false);
        UI_CanvasShoose.SetActive (true);

    
    }

    public void Restart(){
        //Debug.Log (slider.value);
        _media.Control.Seek (0);
        slider.value = 0;
    }
    public void Exit(){
    
        _media.Stop ();
        _media.Control.Seek (0);
        textControll.text = "Play";
        _Camera.transform.position = new Vector3 (0, 0, -14f);
        Particle.SetActive (false);
        UI_Canvas.SetActive (true);
        slider.value = 0;

    }


    public void _StartVideoA(){
      
        _Camera.transform.position = new Vector3 (0, 0, 0);
        UI_Canvas.SetActive (false);
        UI_CanvasShoose.SetActive (false);

        Particle.SetActive (true);
        slider.value = 0;
    }
    public void _StartVideoB(){
        SceneManager.LoadScene ("Video2");
      
    }

    public void ExitGame(){
        Debug.Log ("GoodBye");
        Application.Quit ();
        slider.value = 0;
    }
  
    public void Transaction(float valuetime){
        Debug.Log (slider.value);
        //slider.value = .5f;
       // _media.Control.Seek (0.5f);

        _media.Control.Seek(slider.value*valuetime);
    }
    void Update(){
        if (slider.value >=10) {
            slider.value = 0;
        
        }

       
      

        
        
        
    
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RenderHeads.Media.AVProVideo;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class ControllVedio : MonoBehaviour {
    public MediaPlayer  _media;
 
    public Text textControll;
    public GameObject UI_Canvas;
    public GameObject UI_CanvasShoose;
    public GameObject Particle;

    public Slider slider;
    public float sceond;
    public Transform _Camera;
	// Update is called once per frame
	public void Play_Pause () {
        if (_media.Control.IsPlaying () ) {
            _media.Pause ();
            textControll.text = "Play";

        } else {
            _media.Play ();
            textControll.text = "Pause";
        }

    }
    public void ShooseVideo(){
        UI_Canvas.SetActive (false);
        UI_CanvasShoose.SetActive (true);

    
    }

    public void Restart(){
        //Debug.Log (slider.value);
        _media.Control.Seek (0);
        slider.value = 0;
    }
    public void Exit(){
    
        _media.Stop ();
        _media.Control.Seek (0);
        textControll.text = "Play";
        _Camera.transform.position = new Vector3 (0, 0, -14f);
        Particle.SetActive (false);
        UI_Canvas.SetActive (true);
        slider.value = 0;

    }


    public void _StartVideoA(){
      
        _Camera.transform.position = new Vector3 (0, 0, 0);
        UI_Canvas.SetActive (false);
        UI_CanvasShoose.SetActive (false);

        Particle.SetActive (true);
        slider.value = 0;
    }
    public void _StartVideoB(){
        SceneManager.LoadScene ("Video2");
      
    }

    public void ExitGame(){
        Debug.Log ("GoodBye");
        Application.Quit ();
        slider.value = 0;
    }
  
    public void Transaction(float valuetime){
        Debug.Log (slider.value);
        //slider.value = .5f;
       // _media.Control.Seek (0.5f);

        _media.Control.Seek(slider.value*valuetime);
    }
    void Update(){
        if (slider.value >=10) {
            slider.value = 0;
        
        }

       
      

        
        
        
    
    }
}
>>>>>>> 1b2c6edbed8a07163db0a52e6e22d2ec87c23d1d
