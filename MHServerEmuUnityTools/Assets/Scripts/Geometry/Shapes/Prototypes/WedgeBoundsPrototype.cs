namespace Assets.Scripts.Geometry.Shapes.Prototypes
{
    public class WedgeBoundsPrototype : BoundsPrototype
    {
        public float AngleDegrees { get; protected set; }
        public float BaseWidth { get; protected set; }
        public float Length { get; protected set; }
        public float HeightFromCenter { get; protected set; }

        public override float GetBoundHalfHeight() => HeightFromCenter;
        public override GeometryType GetGeometryType() => GeometryType.Wedge;
    }
}
