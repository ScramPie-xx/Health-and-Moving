using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 10.0f; //�������� NPC
        int levelof = 1; //������� NPC
        float speed = 1.2f;
        health += levelof;
        print("NPC health= " + health); //������� �������� NPC
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
