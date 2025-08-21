using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ActionButtonView : MonoBehaviour, IActionButtonView, IPointerDownHandler,IPointerUpHandler
{
    [SerializeField] private Image _buttonImage;  
    [SerializeField] private Image _cooldownOverlay;

    public event Action OnPressed;
    public event Action OnReleased;

    private bool _interactable = true;

    public void OnPointerDown(PointerEventData eventData)
    {
        if (_interactable)
            OnPressed?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (_interactable)
            OnReleased?.Invoke();
    }

    public void SetInteractable(bool interactable)
    {
        _interactable = interactable;
        
        if (_buttonImage != null)
            _buttonImage.color = interactable ? Color.white : Color.gray;
    }

    public void SetCooldownProgress(float progress)
    {
        if (_cooldownOverlay != null)
            _cooldownOverlay.fillAmount = Mathf.Clamp01(1 - progress); // cái ui progress này bị ngược
    }
}
