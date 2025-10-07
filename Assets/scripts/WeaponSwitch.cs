using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public WeaponType selectedWeapon;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
          selectedWeapon = WeaponType.Sword;
            SelectWeapon(selectedWeapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
          selectedWeapon = WeaponType.Bow;
            SelectWeapon(selectedWeapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
         selectedWeapon = WeaponType.Staff;
            SelectWeapon(selectedWeapon);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
          selectedWeapon = WeaponType.Dagger;
            SelectWeapon(selectedWeapon);
        }
    }

    void SelectWeapon(WeaponType weapon)
    {
        switch (weapon) 
        {
            case WeaponType.Sword:
              Debug.Log("Sword: damage 25, speed 1.0");
              break;
            case WeaponType.Bow:
              Debug.Log("Bow: damage 20, speed 1.5");
              break;
            case WeaponType.Staff:
              Debug.Log("Staff: damage 35, speed 0.7");
              break;
            case WeaponType.Dagger:
              Debug.Log("Dagger: damage 15, speed 2.0");
              break;

            default:
              Debug.Log("damage 10, speed 1.0");
              break;
        }
    }
    public enum WeaponType
    {
        Sword,
        Bow,
        Staff,
        Dagger
    }
}
