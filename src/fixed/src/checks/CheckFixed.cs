//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct CheckFixed
    {
        [MethodImpl(Inline)]
        public static ITestFixedBinaryOp BinaryOp(IPolyrand random)
            => TestFixedBinaryOp.Service(random);
    }
}