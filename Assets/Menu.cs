using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private Animator _animator;
    private CanvasGroup _canvaGroup;
    string IsOpenString = "IsOpen";

    public bool IsOpen
    {
        get { return _animator.GetBool(IsOpenString); }
        set { _animator.SetBool(IsOpenString, value); }
    }
    
    public void Awake()
    {
        _animator = GetComponent<Animator>();
        _canvaGroup = GetComponent<CanvasGroup>();

        var rect = GetComponent<RectTransform>();
        rect.offsetMax = rect.offsetMin = Vector2.zero;
    }

    public void Update()
    {
        if(!_animator.GetCurrentAnimatorStateInfo(0).IsName("Open"))
        {
            _canvaGroup.blocksRaycasts = _canvaGroup.interactable = false;
        }
        else
        {
            _canvaGroup.blocksRaycasts = _canvaGroup.interactable = true;
        }
    }
}
