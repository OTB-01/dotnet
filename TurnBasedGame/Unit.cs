namespace TurnBasedGame;

internal class Unit
{
    private string unitName;
    private int currentHP;
    private int maxHP;
    private int attackPower;
    private int healPower;
    private Random random;

    public int Hp { get { return currentHP; }}
    public String UnitName { get { return unitName; }}

    public Boolean isDead { get {return currentHP <= 0;} } // check remaining hp

    public Unit(int maxHP, int attackPower, int healPower, String unitName)
    {
        this.maxHP = maxHP;
        this.currentHP = maxHP; // start game with max hp
        this.attackPower = attackPower;
        this.healPower = healPower;
        this.unitName = unitName;
        this.random = new Random();
    }

    public void Attack(Unit target)
    {
        double criticalChance = random.NextDouble(); // random number between 0 and 1
        criticalChance = criticalChance / 2 + 0.75f; // this will make the random number between 0.75 and 1.25
        
        // now the attack can be between (75% - 125%) of the Unit attack power
        int damage = (int)(attackPower * criticalChance);
        target.TakeDamage(damage);
        Console.WriteLine($" {unitName} attacks {target.unitName} for {damage} damage");
    }


    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if(isDead){
            Console.WriteLine($" {unitName} is dead");
        }
    }
    public void Heal(){
        double rng = random.NextDouble(); // random number between 0 and 1
        rng = rng / 2 + 0.75f; // this will make the random number between 0.75 and 1.25

        // simmilar to criticalchance, now the heal amount can be between (75% - 125%) of the Unit heal power
        int heal = (int)(healPower * rng);

        currentHP = heal + currentHP > maxHP ? maxHP : heal + currentHP; // if the heal + currentHP is greater than maxHP, then set currentHP to maxHP
        Console.WriteLine($"{unitName} heals for {heal} HP");
    }
}
