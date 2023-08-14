using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YG;

public class ADV : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject obj;

    private Coroutine advCoroutine;
    void Start()
    {
        advCoroutine = StartCoroutine(AdvMove());
    }

    private IEnumerator AdvMove()
    {
        obj.SetActive(false);
        yield return new WaitForSeconds(Random.Range(150,200)*1f);
        obj.SetActive(true);
        int i = 5;
        text.text = $"Реклама: {i}";
        while (i != 0)
        {
            yield return new WaitForSeconds(1f);
            i--;
            text.text = $"Реклама: {i}"; 
        }
        
        YandexGame.FullscreenShow();
        obj.SetActive(false);
        advCoroutine = StartCoroutine(AdvMove());
    }
}
