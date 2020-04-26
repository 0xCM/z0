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

    using K = Kinds.UnaryOpClass;

    public readonly struct CheckFixedDynamic : ICheckFixedDynamic
    {   
        [MethodImpl(Inline)]
        public static ITestDynamic Create(IPolyrand random)        
            => new TestDynamic(random);

        public IPolyrand Random {get;}
                
        [MethodImpl(Inline)]
        public CheckFixedDynamic(IPolyrand random)
            => Random = random;
    }

    public interface ICheckFixedDynamic : ITestRandom, ICheckNull, ICheckDynamic
    {
        void CheckFixedMatch<F>(in BufferSeq dst, K k, IdentifiedCode a, IdentifiedCode b)
            where F : unmanaged, IFixed
        {                        
            var f = Dynamic.EmitFixedUnary<F>(dst[Left], a);
            var g = Dynamic.EmitFixedUnary<F>(dst[Left], b);
            
            var stream = Random.FixedStream<F>();
            notnull(stream);

            var points = stream.Take(RepCount);
            var checker = CheckEqual.Checker;
            iter(points, x => checker.eq(f(x), g(x)));            
        }       
    }
}