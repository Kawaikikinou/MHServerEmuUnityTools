namespace Assets.Scripts.Geometry.Shapes.Prototypes
{
    public class BoxBoundsPrototype : BoundsPrototype
    {
        public float Width { get; protected set; }
        public float Length { get; protected set; }
        public float Height { get; protected set; }
        public bool AxisAligned { get; protected set; }

        public override float GetBoundHalfHeight() => Height * 0.5f;
        public override GeometryType GetGeometryType() => AxisAligned ? GeometryType.AABB : GeometryType.OBB;
    }
}
