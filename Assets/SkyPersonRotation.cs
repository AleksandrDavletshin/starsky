using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SkyPersonRotation : MonoBehaviour
{
public float hourOffset = 0;
	public float speed = 1;

	public IEnumerator SetTime()
	{
		while (true)
        {
            yield return new WaitForSeconds(1f);
            
            var gameObj = gameObject;

	        float timeF = (6 * 60 * 60);
	        float timeO = 360f;
	        float timeOffset = timeO / timeF;

	        var dateTime = DateTime.Now;
	        dateTime = dateTime.AddHours(hourOffset);


		var timeLapse = dateTime.Hour * 60 * 60 + dateTime.Minute * 60 + 
	        dateTime.Second;

			//Debug.Log(timeLapse);
	        gameObj.transform.eulerAngles = new Vector3(
	            gameObj.transform.eulerAngles.x,
	            gameObj.transform.eulerAngles.y,
	            timeLapse * timeOffset 
	        );
        }
	}

	void Start()
    {
        StartCoroutine(SetTime());
    }
}
