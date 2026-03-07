using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public List<GameObject> Writtings;

    void Start()
    {
        GameEvents.ShowEffectsWrittings += ShowEffects;
    }

    private void OnDisable()
    {
        GameEvents.ShowEffectsWrittings -= ShowEffects;
    }

    private void ShowEffects()
    {
        var index = Random.Range(0, Writtings.Count);
        Writtings[index].SetActive(true);
    }
}
