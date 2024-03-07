﻿using Assets.Scripts.Geometry.Maths;

namespace Assets.Scripts.Geometry.Shapes
{
    public class Obb
    {
        public Vector3 Center { get; private set; }
        public Vector3 Extents { get; private set; }
        public Vector3 Orientation { get; private set; }

        public Matrix3 InverseRotationMatrix { get; private set; }

        public Matrix3 RotationMatrix => Matrix3.GetMatrix3(Orientation);

        public Obb(Vector3 center, Vector3 extents, Vector3 orientation)
        {
            Center = center;
            Extents = extents;
            Orientation = orientation;
            InverseRotationMatrix = Matrix3.Inverse(RotationMatrix);
        }

        public Vector3 TransformPoint(Vector3 point)
        {
            return InverseRotationMatrix * (point - Center) + Center;
        }

        public Vector3 TransformVector(Vector3 vec)
        {
            return InverseRotationMatrix * vec;
        }

        public Aabb ToAabb()
        {
            Vector3 oobVector = Matrix3.AbsPerElem(RotationMatrix) * Extents;
            return new Aabb(Center - oobVector, Center + oobVector);
        }

        public bool Intersects(Aabb aabb)
        {
            return ToAabb().Intersects(aabb);
        }

        public bool Intersects(Capsule capsule)
        {
            return capsule.Intersects(this);
        }

        public bool Intersects(Obb obb)
        {
            return ToAabb().Intersects(obb.ToAabb());
        }

        public bool Intersects(Sphere sphere)
        {
            Aabb aabb = new(Center - Extents, Center + Extents);
            Vector3 center = TransformPoint(sphere.Center);
            return aabb.Intersects(new Sphere(center, sphere.Radius));
        }

        public bool Intersects(Triangle triangle)
        {
            Aabb aabb = new(Center - Extents, Center + Extents);
            var otherTriangle = new Triangle(
                TransformPoint(triangle.Points[0]),
                TransformPoint(triangle.Points[1]),
                TransformPoint(triangle.Points[2])
                );
            return aabb.Intersects(otherTriangle);
        }
    }
}
