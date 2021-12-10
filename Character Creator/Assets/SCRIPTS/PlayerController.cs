using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer ArmorRenderer; 
    public SpriteRenderer WeaponRenderer;

    public SpriteRenderer ParticleRenderer;

    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }

    public void SetWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }

    public void SetParticle(Sprite newSprite)
        {
            ParticleRenderer.sprite = newSprite;
        }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
