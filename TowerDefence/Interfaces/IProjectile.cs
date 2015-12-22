
namespace KaminoTD.Interfaces
{
    using Enumerations;

    public interface IProjectile : IGameObject
    {
        int Damage { get; }

        int Speed { get; }

        IEnemy Target { get; }

        ProjectileTypes Type { get; }
    }
}
