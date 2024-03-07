using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Assets.Scripts.Geometry
{
    [StructLayout(LayoutKind.Explicit)]
    public class BoundData
    {
        [FieldOffset(0)]
        public float OBBHalfWidth;
        [FieldOffset(4)]
        public float OBBHalfLength;
        [FieldOffset(8)]
        public float OBBHalfHeight;

        [FieldOffset(0)]
        public float AABBHalfWidth;
        [FieldOffset(4)]
        public float AABBHalfLength;
        [FieldOffset(8)]
        public float AABBHalfHeight;

        [FieldOffset(12)]
        public float AABBOrientedWidth;
        [FieldOffset(16)]
        public float AABBOrientedLength;
        [FieldOffset(20)]
        public float AABBOrientedHeight;

        [FieldOffset(0)]
        public float CapsuleRadius;
        [FieldOffset(4)]
        public float CapsuleHalfHeight;

        [FieldOffset(0)]
        public float SphereRadius;
        [FieldOffset(0)]
        public float TriangleBase;
        [FieldOffset(4)]
        public float TriangleHalfHeight;
        [FieldOffset(8)]
        public float TriangleLength;

        [FieldOffset(0)]
        public float WedgeBaseWidth;
        [FieldOffset(4)]
        public float WedgeBase;
        [FieldOffset(8)]
        public float WedgeHalfHeight;
        [FieldOffset(12)]
        public float WedgeLength;
        public BoundData() { }
    }
}