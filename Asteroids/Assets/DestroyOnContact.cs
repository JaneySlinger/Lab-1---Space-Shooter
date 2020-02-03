using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    GameController gameController;
    GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if(gameControllerObject != null){
            gameController = gameControllerObject.GetComponent<GameController>();

        }
        if(gameController == null){
            Debug.Log("Cannot find 'GameController' script.");
        }

        playerObject = GameObject.FindWithTag("Player");
        if(playerObject == null){
            Debug.Log("Cannot find the 'Player' object");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        gameController.AddScore(10);
        if(other.gameObject == playerObject){
            Application.LoadLevel(Application.loadedLevel);
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
