using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radomPatternMovement : MonoBehaviour {

    public float moveSpeed = 3f;
    public float rotSpeed = 100f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update(){

        if (isWandering == false){
            StartCoroutine(Wander());
        }
        if (isRotatingRight == true){
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }
        if (isRotatingLeft == true){
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }
        if (isWalking == true){
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    IEnumerator Wander(){

        int rotTime = Random.Range(1, 3);
        int rotateLorR = Random.Range(0, 4);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);
        anim.SetBool("isIdle", false);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        anim.SetBool("isIdle", true);
        if (rotateLorR == 1){
            anim.SetBool("isIdle", true);
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
            anim.SetBool("isIdle", true);
        }
        if (rotateLorR == 2){
            anim.SetBool("isIdle", false);
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
            anim.SetBool("isIdle", true);
        }
        isWandering = false;
    }
}
