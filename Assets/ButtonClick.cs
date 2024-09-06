using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballPrefab;

    public TextMeshProUGUI clicksNumber;

    int clicks = 10;

    // Start is called before the first frame update
    void Start()
    {
        clicksNumber.text = "CLICKS: " + clicks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clicks > 0)
        {
            BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);
            ball.transform.localPosition = transform.position;
            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * UnityEngine.Random.Range(300, 1500));
            clicks--;
            clicksNumber.text = "CLICKS: " + clicks.ToString();
        }
        
    }
}

