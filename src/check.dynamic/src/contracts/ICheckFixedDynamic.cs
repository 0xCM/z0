//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static Konst;
    using static z;
    using static BufferSeqId;

    using K = Kinds;

    public interface ICheckFixedDynamic : ITestRandom, TCheckNull, TCheckDynamic, IBufferedChecker
    {
        void CheckFixedMatch<F>(K.UnaryOpClass k, ApiCodeBlock a, ApiCodeBlock b)
            where F : unmanaged, IDataCell
        {
            var f = Dynamic.EmitFixedUnary<F>(Tokens[Left], a);
            var g = Dynamic.EmitFixedUnary<F>(Tokens[Right], b);

            var stream = Random.CellStream<F>();
            notnull(stream);

            var points = stream.Take(RepCount);
            var checker = CheckEqual.Checker;
            iter(points, x => checker.Eq(f(x), g(x)));
        }
    }

}