using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public GameObject hitbox;
    private int money;
    private bool collision_state;
    public Text MoneyText;


    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (collision_state == true) {
            AddMoney();
            collision_state = false;
        }
    }

    
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.gameObject == hitbox)
        {
            Debug.Log("Collision Detected");
            collision_state = true;
        }
    }

    void AddMoney() {
        money ++;
        MoneyText.text = money.ToString();
    }
}
