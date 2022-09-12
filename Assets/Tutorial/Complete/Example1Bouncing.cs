using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityProgrammingBasics.Complete
{
	public class Example1Bouncing : MonoBehaviour
	{
		// Update is called once per frame
	    void Update()
	    {
		    //The time since the game has started
		    float gameTime = Time.time;
		    
		    //The sin value for the current game time (will always be between 1 and -1)
		    //Note Mathf.Sin expects a value in radians, so a full cycle of sin will happen every 2Pi seconds (approx 6.28 seconds)
		    //Therefore the ball will bounce up down and back to its starting position every 6.28 seconds.
		    // *** If you wanted to, how would you speed up the ball? ***
		    float sinTime = Mathf.Sin(gameTime);
	
		    //Set the y component of the GameObjects transform component to be the value of sin(gameTime)
		    transform.localPosition = new Vector3(0, sinTime, 0);
		    
		    //All of the above can be condensed down into:
		    //transform.localPosition = Vector3.up * Mathf.Sin(Time.time);
	    }
	}
}