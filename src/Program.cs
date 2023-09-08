using System.Diagnostics;
using FixedMath.NET;
using ECS.Physics;
using ECS;

class Program
{
    static int Main(string[] args)
    {
        World world = new World();
        world.RegisterComponentType<Transform>();
        world.RegisterSystem<TransformUpSystem>();

        for (int i = 0; i < 1000000; i++)
        {
            int id = world.CreateEntity();
            world.AddComponent<Transform>(id);
        }

        Fix64 deltaTime = (Fix64)0.02;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < 1000; i++)
            world.Tick(deltaTime);
        stopwatch.Stop();

        Console.WriteLine($"Total: {stopwatch.ElapsedMilliseconds}ms");
        Console.WriteLine($"Average: {stopwatch.ElapsedMilliseconds / 1000D}ms");
        return 0;
    }
}