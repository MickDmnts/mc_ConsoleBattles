public class Rogue : Character
{
    public Rogue(){
        _Hp = 100;
        _AttackPower = 10;
        _Armor = 4;
    }

    public override int Attack()
    {
        int _damage = _AttackPower - _Armor;
        return _damage + 2;
    }
}