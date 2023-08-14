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
   void Start()
   {
       twoPlayer.onClick.AddListener(() =>
       {
           _mainPole = Instantiate(pole, transform);
           _mainPole.SetBlock(false);
           mainMenu.SetActive(false);
       });
       EndGame += NewGame;
   }

   private void NewGame()
   {
       _mainPole.SetBlock(true);
       StartCoroutine(NewGameCor());

   }

   private IEnumerator NewGameCor()
   {
       yield return new WaitForSeconds(5f);
       mainMenu.SetActive(true);
       Destroy(_mainPole.gameObject);
   }
}
