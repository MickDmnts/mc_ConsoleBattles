using System.Xml.Linq;

public class Character
{
    public string _Name = "";

    //protected string _Slogan = "";

    //protected int _Level;
    //protected int _Stamina;

    protected int _Hp = 0;
    protected int _AttackPower = 0;
    protected int _Armor;

    //Getters
    public int AttackPower => _AttackPower;
    public int Armor => _Armor;

    //Getters and Setters
    public int Hp
    {
        get { return _Hp; }
        set { _Hp = value; }
    }

      /*protected int _MaxLevel;
        protected int _MaxHp;
        protected int _MaxStamina;
        protected int _MaxAttackPower;
        protected int _MaxArmor;*/

    
    //protected int _Exp;

    public virtual int Attack()
    {
        int _damage = _AttackPower - _Armor;
        return _damage; 
    }
}
