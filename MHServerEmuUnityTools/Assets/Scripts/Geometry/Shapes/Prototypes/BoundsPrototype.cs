using Assets.Scripts.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Geometry.Shapes.Prototypes
{
    public class BoundsPrototype : Prototype
    {
        public BoundsCollisionType CollisionType { get; protected set; }
        public bool BlocksSpawns { get; protected set; }
        public bool ComplexPickingOnly { get; protected set; }
        public bool IgnoreCollisionWithAllies { get; protected set; }
        public bool BlocksLanding { get; protected set; }
        public bool BlocksLineOfSight { get; protected set; }
        public BoundsMovementPowerBlockType BlocksMovementPowers { get; protected set; }
        public bool IgnoreBlockingWithAvatars { get; protected set; }
        public bool BlockOnlyMyself { get; protected set; }

        public virtual float GetBoundHalfHeight() => 0.0f;
        public virtual GeometryType GetGeometryType() => GeometryType.None;
    }
}
