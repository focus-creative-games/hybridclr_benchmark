using BenchmarkTool;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class First
{
    [Benchmark]
    public void Sleep()
    {
        Thread.Sleep(Random.Range(10, 20));
    }

    [Benchmark]
    [Params(1, 2)]
    public void Sum(int a, int b)
    {
        
    }
}
