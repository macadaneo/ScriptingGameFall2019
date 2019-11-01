using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
   public UnityAction<GameObject> instanceAction;

   public UnityEvent OnRunEvent;

   public List<WeaponData> weapon;
   public ClothsData shirt;
   public ClothsData pants;
   public FloatData health;


   public void InstancePlayer()
   {
      var newPlayer = Instantiate(prefab);

      var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
      newSprite.sprite = sprite;
      newSprite.color = spriteColor;
      instanceAction(newPlayer);
   }

   public void Run()
   {
      OnRunEvent.Invoke();
   }
}