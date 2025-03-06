using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonParent : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TMP_Text _text;

    private void Awake()
    {
        _text = GetComponentInChildren<TMP_Text>();
    }

    private void Start()
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //_text.gameObject.transform.localRotation = 
        _text.gameObject.transform.localScale = new Vector3(1.1f,1.1f,1.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _text.color = Color.white;
        _text.gameObject.transform.localScale = Vector3.one;
    }
}
