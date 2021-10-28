using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.WeaponSpawner
{
    public class SpawnerWeapon
    {
        //exercise 

        private _Weapon prototype;

        //exercise
        public SpawnerWeapon(_Weapon prototype)
        {
            this.prototype = prototype;
        }

        public _Weapon SpawnWeapon()
        {
            return prototype.Clone();
        }
    }
}
