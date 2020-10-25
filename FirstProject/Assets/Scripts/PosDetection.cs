using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosDetection : MonoBehaviour
{
    public GameObject actor;
    public GameObject Particlefeb;
    Vector3 actorXZ;
    Vector3 ParticlefebXZ;
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
        actorXZ = new Vector3(actor.transform.position.x, 0, actor.transform.position.z);

        ParticlefebXZ = new Vector3(Particlefeb.transform.position.x, 0, Particlefeb.transform.position.z);
        if (Vector3.Distance(actorXZ,ParticlefebXZ)<0.3)
        {
            return true;
        }
       
        return false;
    }

}
