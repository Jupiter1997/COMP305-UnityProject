using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    public Transform player;
    public float xOffset = 2;

    private Transform camTrans;

    void Start()
    {
        camTrans = this.transform;
    }

    void Update()
    {
        camTrans.position = new Vector3(player.position.x - xOffset, player.position.y , camTrans.position.z);
    }
}
