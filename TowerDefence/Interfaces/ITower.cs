
namespace KaminoTD.Interfaces
{
    using Enumerations;

    public interface ITower : IGameObject
    {
        TowerTypes Type { get; }

        int Speed { get; }

        int Range { get; }

        IEnemy Target { get; }

        int Price { get; }

        int Level { get; }

        IProjectile Projectile { get; }

        IProjectile FireProjectile();

        void Upgrade();
    }
}
