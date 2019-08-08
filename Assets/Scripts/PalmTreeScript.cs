using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalmTreeScript : MonoBehaviour
{
    
    
    void Start(){

    }

    public void OnClickCreateBubbles()
    {
        var bubblesPrototype = Resources.Load("Bubbles", typeof(GameObject)) as GameObject;
        var newBubbles = GameObject.Instantiate(bubblesPrototype);
        var bubblesRb = newBubbles.GetComponent<Rigidbody>();
    }
    

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
