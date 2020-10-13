using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animation anim;
    public string AnimName;  //动画的名字
    void Start()
    {
        anim = this.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AnimStart()
    {
        anim.Play(AnimName);
    }
    public void AnimStop()
    {
        anim.Stop(AnimName);
    }

}