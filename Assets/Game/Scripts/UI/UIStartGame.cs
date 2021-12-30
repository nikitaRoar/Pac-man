using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStartGame : MonoBehaviour
{
    [SerializeField] private GameObject _view = null;
    
    public void StartGameButton() 
    {
        _view.SetActive(false);
        GameplayManager.Instance.StartGame();
    }
}
