
namespace KaminoTD.Geometry
{
    using System;
    using Microsoft.Xna.Framework;

    public static class GeometryCalcs
    {
        public static void HandleMovement(Vector2 objectPosition, Vector2 targetPosition, double speed)
        {
            if (CalculateDistance(objectPosition, targetPosition) < speed)
            {
                objectPosition.X = targetPosition.X;
                objectPosition.Y = targetPosition.Y;
            }

            float deltaX = targetPosition.X - objectPosition.X;
            float deltaY = targetPosition.Y - objectPosition.Y;
            float angle = (float)Math.Atan2(deltaY, deltaX);
            objectPosition.X += (float)(speed * Math.Cos(angle));
            objectPosition.Y += (float)(speed * Math.Sin(angle));
        }

        public static double CalculateDistance(Vector2 currentPoint, Vector2 target)
        {
            float distance = (float)Math.Sqrt(Math.Pow(target.X - currentPoint.X, 2) +
                Math.Pow(target.Y - currentPoint.Y, 2));

            return distance;
        }
    }
}
