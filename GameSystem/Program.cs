using System;
using MyGame.Characters;
using MyGame.Items;

Console.WriteLine("=== 캐릭터 시스템 ===");
Player player = new Player{ Name = "용사" };
Enemy enemy = new Enemy { Type = "고블린" };
Weapon weapon = new Weapon { Name = "불꽃검" };
Potion potion = new Potion { Name = "체력 포션" };
player.Attack();
enemy.TakeDamage();
Console.WriteLine();
Console.WriteLine("=== 아이템 시스템 ===");
weapon.GetDamage(50);
potion.Use();

namespace MyGame.Characters
{
    class Player
    {
        public string Name;
        public void Attack()
        {
            Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
        }
    }
    class Enemy
    {
        public string Type;
        public void TakeDamage()
        {
            Console.WriteLine($"적 {Type}(이)가 데미지를 받았습니다!");
        }
    }
}

namespace MyGame.Items
{
    class Weapon
    {
        public string Name;
        public void  GetDamage(int attackPower)
        {
            Console.WriteLine($"무기 {Name}의 공격력: {attackPower}");
        }
    }
    class Potion
    {
        public string Name;
        public void Use()
        {
            Console.WriteLine($"포션 {Name}을(를) 사용했습니다.");
        }
    }
}
