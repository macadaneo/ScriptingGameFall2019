using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : GameArtData
{

   public List<WeaponData> weapon;
   public ClothsData shirt;
   public ClothsData pants;
   public FloatData health;


   public void InstancePlayer()
   {
      var newPlayer = Instantiate(prefab);

      var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
      newSprite.sprite = sprite;
      newSprite.color = color;
   }
}
