using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SobekPassive : SummonPassive
{
    // Start is called before the first frame update
    public SummonPassive sp;
    void Start()
    {
        sp = gameObject.GetComponent<SummonPassive>();
        sp.vida = 400;
        sp.dano = 40;
        sp.velocidadeAtaque = 3;
        sp.velocidadeMovimento = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
