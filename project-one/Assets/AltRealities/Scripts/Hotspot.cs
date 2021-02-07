using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotspot : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = Camera.main.transform.parent.gameObject;
    }

    public void OnPointerClick()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        LeanTween.move(player, transform.position, distance / 2f);
    }
}
