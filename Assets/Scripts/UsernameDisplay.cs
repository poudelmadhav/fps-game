using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class UsernameDisplay : MonoBehaviour
{
    [SerializeField] PhotonView playerPV;
    [SerializeField] TMP_Text text;

    void Start()
    {
        if (playerPV.IsMine) {
            text.text = PhotonNetwork.NickName;
        } else {
            text.text = playerPV.Owner.NickName;
        }
    }
}
