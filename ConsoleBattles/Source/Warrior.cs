public class Warrior : Character
{
    public Warrior()
    {
        _Hp = 150;
        _AttackPower = 10;
        _Armor = 6;
    }
    public override int Attack()
    {
       return base.Attack();
    }
}