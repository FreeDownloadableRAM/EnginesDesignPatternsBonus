using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class Sword : _Weapon
    {
        private int attack;
        private int durability;

        private static int swordCounter = 0;

        public Sword(int attack, int durability)
        {
            this.attack = attack;
            this.durability = durability;

            swordCounter += 1;
        }

        public override _Weapon Clone()
        {
            return new Sword(attack, durability);
        }

        public override void Talk()
        {
            Debug.Log($"This is sword number: {swordCounter}. Weapon Attack damage bonus is {attack} and its durability is {durability}");
        }
    }
}