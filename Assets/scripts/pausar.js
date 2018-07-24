#pragma strict

function Start () {

}

function Update () {

  if(Input.GetKeyDown('p')){
        if(Time.timeScale == 1){    
             Time.timeScale = 0;    
        } else if(Time.timeScale == 0) {   
             Time.timeScale = 1;    
        }
    }

}