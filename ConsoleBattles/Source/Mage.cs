public class Mage : Character
{
    public Mage()
    {
        _Hp = 100;
        _AttackPower = 10;
        _Armor = 4;
    }

    public override int Attack()
    {
        return _AttackPower;
    }
}