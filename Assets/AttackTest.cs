using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AttackTest : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    GameObject Cactus1;
    GameObject Cactus2;

    void Start()
    {
        Debug.Log("Start");
        anim = GetComponent<Animator>();

        Cactus1 = GameObject.Find("Cactus1");
        Cactus2 = GameObject.Find("Cactus2");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("test");
        if (anim != null)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                anim.SetTrigger("Attack2");
            }
        }

        float distance = Vector3.Distance(Cactus1.transform.position, Cactus2.transform.position);

        if(distance <= 5)
        {
            anim.SetTrigger("Attack2");
        }
    }
}
