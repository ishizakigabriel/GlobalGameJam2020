using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HachimanPassive : SummonPassive
{
    // Start is called before the first frame update
    public SummonPassive sp;
    void Start()
    {
        sp = gameObject.GetComponent<SummonPassive>();
        sp.vida = 200;
        sp.dano = 70;
        sp.velocidadeAtaque = 3;
        sp.velocidadeMovimento = 10;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
