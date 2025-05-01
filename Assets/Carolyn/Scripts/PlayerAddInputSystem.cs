using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAddInputSystem : MonoBehaviour
{

    //C. Getting the animator
    private Animator _animator;

    //C. Getting input script
    private StarterAssetsInputs _input;

    //C. Getting player input asset
    private PlayerInput _playerInput;

    // Start is called before the first frame update
    void Start()
    {
        //C. referencing everything
        _input = GetComponent<StarterAssetsInputs>();
        _playerInput = GetComponent<PlayerInput>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_input.punch)
        {
            _animator.SetBool("Punch", true);
            OnPunch1AnimationEnd();
        }
    }

    public void OnPunch1AnimationEnd()
    {
        _input.punch = false;
        Debug.Log("event called");
    }
}
