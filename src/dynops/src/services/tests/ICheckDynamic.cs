//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    
    using static BufferSeqId;
    using static Memories;
    using static TestDynamic;

    using K = Kinds.UnaryOpClass;

    public interface ICheckDynamic : ITester
    {
        void CheckFixedMatch<F>(in BufferSeq dst, K k, IdentifiedCode a, IdentifiedCode b)
            where F : unmanaged, IFixed
        {                        
            var f = Dynamic.EmitFixedUnary<F>(dst[Left], a);
            var g = Dynamic.EmitFixedUnary<F>(dst[Left], b);
            
            var stream = Random.FixedStream<F>();
            Check.notnull(stream);

            var points = stream.Take(RepCount);
            iter(points, x => Check.eq(f(x), g(x)));            
        }       
    }
}