using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HTC.UnityPlugin.Vive;
using UnityEngine.Playables;

public class RayIn : MonoBehaviour
{
   Transform JieShaoUI;

    void Start()
    {

    }
    void Update()
    {

        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
   
        if (Physics.Raycast(transform.position, fwd, out hit, 10000))
        {

            Debug.DrawLine(transform.position, hit.point, Color.red);
            //Debug.Log("射线检测到的物体名称: " + hit.transform.name);
            if (ViveInput.GetPressDownEx(HandRole.RightHand, ControllerButton.Trigger) && hit.transform.tag == "Build")
            {
                
                GetComponent<AudioControl>().AudioStart();
                JieShaoUI = hit.transform.Find("Canvas");
                if (JieShaoUI.gameObject.active==false)
                {
                    JieShaoUI.gameObject.SetActive(true);
                }

                else
                    JieShaoUI.gameObject.SetActive(false);
            }

        }
    }
}