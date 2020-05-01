//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static BufferSeqId;
    using static Memories;

    using K = Kinds;

    public interface ICheckFixedDynamic : ITestRandom, ICheckNull, ICheckDynamic, IBufferedChecker
    {
        void CheckFixedMatch<F>(K.UnaryOpClass k, OperationCode a, OperationCode b)
            where F : unmanaged, IFixed
        {                        
            var f = Dynamic.EmitFixedUnary<F>(Buffers[Left], a);
            var g = Dynamic.EmitFixedUnary<F>(Buffers[Right], b);
            
            var stream = Random.FixedStream<F>();
            notnull(stream);

            var points = stream.Take(RepCount);
            var checker = CheckEqual.Checker;
            iter(points, x => checker.eq(f(x), g(x)));            
        }       
    }
}