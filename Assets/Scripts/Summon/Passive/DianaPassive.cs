using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DianaPassive : SummonPassive
{
    // Start is called before the first frame update
    public SummonPassive sp;
    void Start()
    {
        sp = gameObject.GetComponent<SummonPassive>();
        sp.vida = 300;
        sp.dano = 80;
        sp.velocidadeAtaque = 4;
        sp.velocidadeMovimento = 15;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
