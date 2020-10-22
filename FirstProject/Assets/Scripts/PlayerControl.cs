using HTC.UnityPlugin.Vive;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
   public GameObject UI;
    void Start()
    {
       // ViveInput.AddListenerEx(HandRole.RightHand, ControllerButton.Trigger, ButtonEventType.Down, OnTrigger);//监听右手手柄
    }



    // Update is called once per frame
    void Update()
    {
        if (ViveInput.GetPressDownEx(HandRole.RightHand, ControllerButton.Grip))//若是右手ControllerButton.Grip，则是鼠标中键，右手握持键进行选项的选择，pad是触摸角度
        {
            Debug.Log("切换场景功能");//可以写事件，切换镜头把主摄像机切换到
        }
      //  Debug.Log(ViveInput.GetPadTouchAxis(HandRole.RightHand));//获取Pad,鼠标+shift移动,与监听配套，获取右手手柄的摆动
       

        // Debug.Log(ViveInput.GetAxis(HandRole.RightHand,ControllerAxis.Trigger));//时刻更新占运行内存
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Go")
        {
            UI.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Go")
        {
            UI.SetActive(false);
        }
    }
    public void OnTrigger()
    {
        Debug.Log("OnTrigger");
    }
}
