using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/** Temporarily disabled as now animations given with Gaias new model as of 16/4/25 **/

public class AnimationInitialiser : MonoBehaviour
{
    public Animator rigAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            // rigAnimator.Play();
        }
    }
}
