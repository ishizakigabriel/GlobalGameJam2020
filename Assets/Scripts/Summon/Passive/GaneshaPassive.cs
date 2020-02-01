using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaneshaPassive : SummonPassive
{
    // Start is called before the first frame update
    private SummonPassive sp;
    private Spirit spirit;

    void initStatus()
    {
        sp.vida = 670 + 30 * spirit.passiveLevel;
        sp.dano = 16 + 4 * spirit.passiveLevel;
        sp.velocidadeAtaque = 2 + spirit.passiveLevel;
        sp.velocidadeMovimento = 2 + 2 * spirit.passiveLevel;
    }

    void Start()
    {
        spirit = gameObject.GetComponent<Spirit>();
        sp = gameObject.GetComponent<SummonPassive>();
        initStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
