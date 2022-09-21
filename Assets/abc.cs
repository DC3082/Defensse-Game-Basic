using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abc : MonoBehaviour
{  // public Transform myHeroTransform;

    float playerScore;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = PlayerPrefs.GetFloat ("123", 0);
        playerScore += 20;
        

        PlayerPrefs.SetFloat ("123", playerScore);
        Debug.Log (playerScore);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

  /*  private void OnCollisionEnter2D (Collision2D EnterEvent)
    {

        myHeroTransform.position = new Vector3 (2, 2, 0);

        Debug.Log ("VoHamHam");

        Debug.Log (myHeroTransform.GetComponent<SpriteRenderer>().color = Color.red);

        Debug.Log (EnterEvent.gameObject.GetComponent<SpriteRenderer>().color = Color.blue);
    }

    private void OnCollisionStay2D (Collision2D StayEvent)

    {

       Debug.Log (StayEvent.gameObject.GetComponent<SpriteRenderer>().color = Color.green);

    }

     private void OnCollisionExit2D (Collision2D ExitEvent)

    {
        Debug.Log (ExitEvent.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow);

    }*/

   
}
