using Assets.Scripts.Geometry.Shapes;

namespace Assets.Scripts.Geometry
{
    public interface IBounds
    {
        ContainmentType Contains(Aabb2 bounds);
        bool Intersects(Aabb bounds);
    }
}
