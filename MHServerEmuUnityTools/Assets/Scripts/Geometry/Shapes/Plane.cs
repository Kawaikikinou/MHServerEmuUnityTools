﻿using Assets.Scripts.Geometry.Maths;

namespace Assets.Scripts.Geometry.Shapes
{
    public class Plane
    {
        public enum IntersectionType
        {
            Back,
            Front,
            Intersect
        }

        public Vector3 Normal { get; set; }
        public float D { get; set; }


        public Plane(Vector3 normal, float d)
        {
            Normal = normal;
            D = d;
        }

        public IntersectionType Intersects(Aabb bound)
        {
            IntersectionType[] intersection = new IntersectionType[8];
            Vector3[] corners = bound.GetCorners();

            intersection[0] = Intersects(corners[0]);
            for (int i = 1; i < 8; i++)
            {
                intersection[i] = Intersects(corners[i]);
                if (intersection[i] != intersection[0])
                    return IntersectionType.Intersect;
            }

            return intersection[0];
        }

        public IntersectionType Intersects(Vector3 point)
        {
            float distance = SignedDistanceToPoint(point);
            if (distance > 0.0f)
                return IntersectionType.Front;
            else if (distance < 0.0f)
                return IntersectionType.Back;
            else
                return IntersectionType.Intersect;
        }

        public float SignedDistanceToPoint(Vector3 point)
        {
            return Vector3.Dot(point, Normal) - D;
        }

    }
}
