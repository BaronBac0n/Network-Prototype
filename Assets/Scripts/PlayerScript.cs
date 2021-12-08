using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public string username;

    public Text usernameDisplay;

    private void Start()
    {
        print(PhotonNetwork.NickName);
    }

    private void Update()
    {
        if (usernameDisplay == null)
        {
            usernameDisplay = GameObject.FindGameObjectWithTag("Username Display").GetComponent<Text>();
            usernameDisplay.text = PhotonNetwork.NickName;
        }
        else
        {
            //Debug.LogError("The Username Display is not tagged correctly");
        }
    }

}
