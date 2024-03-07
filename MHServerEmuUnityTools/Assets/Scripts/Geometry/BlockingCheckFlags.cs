using System;

namespace Assets.Scripts.Geometry
{
    [Flags]
    public enum BlockingCheckFlags
    {
        None = 0,
        CheckSpawns = 1,
        CheckGroundMovementPowers = 2,
        CheckAllMovementPowers = 4,
        CheckLanding = 8,
        CheckSelf = 16, // ??
    }
}
