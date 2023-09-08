using FixedMath.NET;

namespace ECS.Physics;


public struct AABB : IComponent
{
    public Vector2 center;
    public Vector2 size;
    public Vector2 offset;
    
    public Vector2 Extents => size / 2;
    public Vector2 Min => center - Extents;
    public Vector2 Max => center + Extents;

    public static bool Intersection(AABB a, AABB b)
    {
        if (a.Max.x < b.Min.x || a.Min.x > b.Max.x) return false;
        if (a.Max.y < b.Min.y || a.Min.y > b.Max.y) return false;
        return true;
    }
}