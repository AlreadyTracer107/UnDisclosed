using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimes : MonoBehaviour {
	public GameObject slime;
    private float newX;
    private float newY;
    private float currX;
    private float currY;

	void Start () {
		newRandomLocation();
        StartCoroutine(moveDelay());
	}
	void Update () {
		
	}
    void NewXposition(){
        var currLoc= slime.GetComponent<Transform>();
        currX = currLoc.localPosition.x;
        newX = currX + Random.Range(-3f,3f);
        if (newX < -3.3 || newX > 3.3){
            NewXposition();
        }
    }
    
    void NewYposition(){
        var currLoc= slime.GetComponent<Transform>();
        currY = currLoc.localPosition.y;
        newY = currY + Random.Range(-3f,3f);
        if (newY < -3.3 || newY > 3.3){
            NewYposition();
        }
    }
    void move(){
        var currLoc= slime.GetComponent<Transform>();
        slime.transform.position = new Vector2(newX,newY);
        // while(currX<newX){
        //     //moveRight
            
        // }
        // while(currY<newY){
        //     //moveUp
        // }
    }
	void newRandomLocation(){
        NewXposition();
        NewYposition();
        move();
        print("x:"+newX);
        print("y:"+newY);
	}	

    IEnumerator moveDelay()
    {
        newRandomLocation();
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(moveDelay());
    }
    //attacks
}

