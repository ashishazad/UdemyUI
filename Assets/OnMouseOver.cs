using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnMouseOver : MonoBehaviour, UnityEngine.EventSystems.IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("You are over me!!");
    }

    public void PrintSomething(string blegh)
    {
        Debug.Log(blegh);
    }
}
