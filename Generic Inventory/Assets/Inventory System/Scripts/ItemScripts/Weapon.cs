
using UnityEngine;
[CreateAssetMenu(fileName = "Weapon", menuName = "Item/Weapon")]
public class Weapon : Item
{
    public weaponType type;
    public int weaponDamage;
    public override void Use()
    {
        base.Use();

        //Equip Action
       
        //Use the following line if you want to destroy this type of item after use
        // Inventory.instance.RemoveItem(this, 1);
    }

    public enum weaponType { Shield, Arrow, Armour,Dagger,Halmet,Gloves}
}
