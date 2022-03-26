using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject weapon;
    public bool isAttacking;
    
    void Update() {
        if (Input.GetMouseButtonDown(0) && !isAttacking) {
            isAttacking = true;
            weapon.SetActive(true);
            Invoke("HideWeapon", 0.5f);
        }
    }

    void HideWeapon()
    {
        isAttacking = false;
        weapon.SetActive(false);
    }
}
