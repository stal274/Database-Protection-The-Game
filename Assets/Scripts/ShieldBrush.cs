using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class ShieldBrush : MonoBehaviour
{
    [SerializeField] private SpriteAtlas _sprites;
    
    public void RenderingTheDestructionLayer(int i)
    {
        
        gameObject.GetComponent<SpriteRenderer>().sprite = _sprites.GetSprite("Stage " + i);

    }
}
