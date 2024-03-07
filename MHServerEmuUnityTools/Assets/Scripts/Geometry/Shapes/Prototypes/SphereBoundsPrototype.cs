namespace Assets.Scripts.Geometry.Shapes.Prototypes
{
    public class SphereBoundsPrototype : BoundsPrototype
    {
        public float Radius { get; protected set; }

        public override float GetBoundHalfHeight() => Radius;
        public override GeometryType GetGeometryType() => GeometryType.Sphere;
    }
}
