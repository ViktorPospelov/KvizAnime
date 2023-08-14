using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    [SerializeField] private Pole pole;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private Button twoPlayer;

    private Pole _mainPole;
    public static Action EndGame;

    public void Player2()
    {
        _mainPole = Instantiate(pole, transform);
        _mainPole.SetBlock(false);
        mainMenu.SetActive(false);
        _mainPole.SetBot(false);


        EndGame += NewGame;
    }

    public void Player1()
    {
        _mainPole = Instantiate(pole, transform);
        _mainPole.SetBlock(false);
        mainMenu.SetActive(false);
        _mainPole.SetBot(true);


        EndGame += NewGame;
    }

    private void NewGame()
    {
        _mainPole.SetBlock(true);
        StartCoroutine(NewGameCor());
    }

    private IEnumerator NewGameCor()
    {
        twoPlayer.onClick.RemoveAllListeners();
        EndGame -= NewGame;
        yield return new WaitForSeconds(5f);
        mainMenu.SetActive(true);
        if (_mainPole.gameObject.activeSelf) Destroy(_mainPole.gameObject);
    }
}