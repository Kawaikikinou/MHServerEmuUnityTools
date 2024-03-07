namespace Assets.Scripts.Geometry.Shapes.Prototypes
{
    public class CapsuleBoundsPrototype : BoundsPrototype
    {
        public float Radius { get; protected set; }
        public float HeightFromCenter { get; protected set; }

        public override float GetBoundHalfHeight() => HeightFromCenter;
        public override GeometryType GetGeometryType() => GeometryType.Capsule;
    }
}
