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
   void Start()
   {
       twoPlayer.onClick.AddListener(() =>
       {
           _mainPole = Instantiate(pole, transform);
           _mainPole.SetBlock(false);
           mainMenu.SetActive(false);
       });
       
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
