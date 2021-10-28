using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Prototype.WeaponSpawner

{
    public class SpawnControllerWeapon : MonoBehaviour
    {
        private Sword swordPrototype;

        private SpawnerWeapon[] weaponSpawners;

        void Start()
        {
            
            //exercise
            swordPrototype = new Sword(16, 12);//attack bonus, and durability

            //exercise
            weaponSpawners = new SpawnerWeapon[] {
                new SpawnerWeapon(swordPrototype),

            };


        }


        void Update()
        {
            if (Input.GetKeyDown("1"))
            {


                SpawnerWeapon swordSpawner = new SpawnerWeapon(swordPrototype);

                Sword newSword = swordSpawner.SpawnWeapon() as Sword;

                newSword.Talk();


            }
        }
    }
}
