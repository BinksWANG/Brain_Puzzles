using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _gamePanel;

    [SerializeField] private List<GameObject> _rows;

    private void Start()
    {
        _startPanel.SetActive(true);
        _gamePanel.SetActive(false);
    }

    public void StartGame() 
    {
        Debug.Log("Click Start ");
        _startPanel.SetActive(false);
        _gamePanel.SetActive(true);
    }

    public void InitializePuzzles() 
    {
        
    }
}
