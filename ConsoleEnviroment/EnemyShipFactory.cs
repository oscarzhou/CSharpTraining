
namespace ConsoleEnviroment
{
    public class EnemyShipFactory
    {
        public EnemyShip makeEnemyShip(string newShipType)
        {
            EnemyShip newShip = null;
            if (newShipType.Equals("U"))
            {
                return new UFOEnemyShip();
            }
            else if (newShipType.Equals("R"))
            {
                return new RocketEnemyShip();
            }
            else if (newShipType.Equals("B"))
            {
                return new BigUFOEnemyShip();
            }
            else
            {
                return null;
            }
        }
    }
}
