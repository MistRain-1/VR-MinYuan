using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosDetection : MonoBehaviour
{
    public GameObject actor;
    public GameObject Particlefeb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ReachPos() == true)
        {
            this.GetComponent<ProjectControl>().ShowInterface();
        }
        else
        {
            this.GetComponent<ProjectControl>().CloseInterface();
        }
    }
    public bool ReachPos()
    {
        if (actor.transform.position.x - Particlefeb.transform.position.x<=0.05)
        {
            return true;
        }
        return false;
    }

}
