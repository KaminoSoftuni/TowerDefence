
namespace KaminoTD.Interfaces
{
    public interface IProjectile : IGameObject
    {
        int Damage { get; }

        int Speed { get; }

        IEnemy Target { get; }
    }
}
