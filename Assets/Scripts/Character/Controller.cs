using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update

    public KeyCode left;
    public KeyCode right;

    public Movement character;

    public string skillname1;
    public string skillname2;
    public string skillname3;
    public string skillname4;

    

    public SummonPassive skill1;
    public SummonActive skill2;
    public SummonActive skill3;
    public SummonActive skill4;

    void Start()
    {
        left = KeyCode.A;
        right = KeyCode.D;

        System.Type type1 = System.Type.GetType(skillname1 + "Passive");

       
        character = gameObject.GetComponent<Movement>();
        character.baseSpeed = skill1.velocidadeMovimento;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(left))
        {
            character.moveLeft();
        }
        if (Input.GetKeyDown(right))
        {
            character.moveRight();
        }
        if (Input.GetKeyUp(left) || Input.GetKeyUp(right))
        {
            character.stopMoving();
        }
    }
}
