using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickControl : MonoBehaviour
{
     private Button _button;
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(() =>
        {
            Click();
        });
    }

    public void Click()
    {
        Pole.ClikMove?.Invoke();
        _button.onClick.RemoveAllListeners();
        Destroy(gameObject);
    }
   
}
