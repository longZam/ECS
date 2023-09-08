using System.Diagnostics;
using FixedMath.NET;

namespace ECS;

public class TransformUpSystem : System
{
    public override void Tick(World world, Fix64 deltaTime)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        world.ForEach((ref Transform transform) =>
        {
            transform.position += Vector2.up * deltaTime;
        });

        stopwatch.Stop();
        Console.WriteLine($"Timer: {stopwatch.ElapsedMilliseconds}ms");
    }
}