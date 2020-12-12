//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct PipeChecks
    {
        public static void check(IWfShell wf)
        {
            using var running = wf.Running();

            var pipe = Pipes.pipe<ushort>();
            var count = 10;
            var input = wf.Random.Span<ushort>(count);
            for(var i=0; i<count; i++)
                pipe.Deposit(skip(input,i));

            var output = hashset<ushort>();
            while(pipe.Next(out var dst))
                output.Add(dst);

            insist(output.Count, count);

            for(var i=0; i<count; i++)
                insist(output.Contains(skip(input,i)));

            wf.Status($"Ran {count} values through pipe");
        }
    }
}