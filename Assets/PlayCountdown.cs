using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class PlayCountdown : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text tMP_Text;
    public UnityEvent OnStart;
    public UnityEvent OnEnd;

    public void Start()
    {
        OnStart.Invoke();
        var sequence = DOTween.Sequence();
        tMP_Text.transform.localScale = Vector3.zero;
        tMP_Text.text = "3";
        sequence.Append(tMP_Text.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tMP_Text.transform.localScale = Vector3.zero;
                tMP_Text.text = "2";
            }));
        
        sequence.Append(tMP_Text.transform.DOScale(
            Vector3.one,
            1).OnComplete(() => 
            {
                tMP_Text.transform.localScale = Vector3.zero;
                tMP_Text.text = "1";
            }));
        
        sequence.Append(tMP_Text.transform.DOScale(
            Vector3.one,
            1).OnComplete(() =>
            {
                tMP_Text.transform.localScale = Vector3.zero;
                tMP_Text.text = "GO";
                OnEnd.Invoke();
            }));
    }
}
