using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    [SerializeField] MobileControlView _mobileControlView;
    
    [SerializeField] CharaterEx _charaterPf;
    
    
    private IControlModel _playerControlModel;
    private CharaterEx _player;

    private void Start()
    {
        BuildPlayerControl();
        BuildPlayer();
    }

    private void BuildPlayerControl()
    {
        _playerControlModel = new ControlModel();
        var controlPresenter = new ControlPresenter(_mobileControlView, _playerControlModel);
    }

    private void BuildPlayer()
    {
        _player = Instantiate(_charaterPf);
        _player.InjectControl(_playerControlModel);
    }
}
