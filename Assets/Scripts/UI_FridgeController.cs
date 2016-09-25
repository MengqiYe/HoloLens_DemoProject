using UnityEngine;
using System.Collections;

public class UI_FridgeController : MonoBehaviour
{
    private Animator _animator;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TriggerOpen()
    {
        _animator.SetTrigger("TriggerOpen");
    }

    public void TiggerClose()
    {
        _animator.SetTrigger("TriggerClose");
    }
}
