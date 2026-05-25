// using System.Diagnostics;
// Console.WriteLine("Start");
// var sw=Stopwatch.StartNew();
// for(int i = 0; i < 5; i++)
// {
//     Thread.Sleep(300);
// }
// Console.WriteLine($"Blocking sequtial:{sw.ElapsedMilliseconds}ms");

// sw.Restart();

// for(int i=0; i<5; i++)
// {
//     await Task.Delay(300);
// }
// Console.WriteLine($"Async sequtial:{sw.ElapsedMilliseconds}ms");

// sw.Restart();
// var tasks=Enumerable.Range(0,5).Select(_ =>Task.Delay(300));
// await Task.WhenAll(tasks);
// Console.WriteLine($"Async Parallel: {sw.ElapsedMilliseconds}ms");

// Console.WriteLine("end");




// using System.Data.Common;
// using System.Reflection.Metadata;
// using System.Security.Cryptography;

// public class student
// {
//    public string Id  
// }

