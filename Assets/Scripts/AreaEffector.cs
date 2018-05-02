using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {

    public float time;
    public GameObject efector;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    //El tiempo se suma constantemente
        time += Time.deltaTime;
        //Entre este tiempo va a funcionar el efector, entre 2 y 6 segundos
        if (time > 2 && time <6)
        {
            efector.SetActive(true);

        }
        //Para que cuando comience este apagado
        else if (time < 2)
        {
            efector.SetActive(false);
        }
        //Luego de ello se resetea definiendo time =0
        else if (time>6)
        {
            efector.SetActive(false);
            time = 0;
        }
	}
}
